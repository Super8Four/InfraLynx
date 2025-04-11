using Infralynx.Core.Models;
using Infralynx.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Infralynx.Web.Pages.Devices;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Device> Devices { get; set; } = default!;
    public string NameSort { get; set; } = "name_desc";
    public string CurrentFilter { get; set; } = string.Empty;

    public async Task OnGetAsync(string sortOrder, string searchString)
    {
        NameSort = sortOrder == "name" ? "name_desc" : "name";
        CurrentFilter = searchString ?? string.Empty;

        IQueryable<Device> devices = _context.Devices
            .Include(d => d.Site);

        if (!string.IsNullOrEmpty(searchString))
        {
            devices = devices.Where(d => 
                d.Name.Contains(searchString) ||
                d.DeviceType.Contains(searchString) ||
                d.Status.Contains(searchString) ||
                d.Role.Contains(searchString) ||
                d.Site.Name.Contains(searchString));
        }

        devices = sortOrder switch
        {
            "name" => devices.OrderBy(d => d.Name),
            "name_desc" => devices.OrderByDescending(d => d.Name),
            _ => devices.OrderBy(d => d.Name),
        };

        Devices = await devices.AsNoTracking().ToListAsync();
    }
} 