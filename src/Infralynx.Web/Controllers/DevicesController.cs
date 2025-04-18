using Infralynx.Core.Models;
using Infralynx.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Infralynx.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DevicesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public DevicesController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Devices
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Device>>> GetDevices()
    {
        return await _context.Devices
            .Include(d => d.Site)
            .Include(d => d.Rack)
            .ToListAsync();
    }

    // GET: api/Devices/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Device>> GetDevice(int id)
    {
        var device = await _context.Devices
            .Include(d => d.Site)
            .Include(d => d.Rack)
            .FirstOrDefaultAsync(d => d.Id == id);

        if (device == null)
        {
            return NotFound();
        }

        return device;
    }

    // PUT: api/Devices/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutDevice(int id, Device device)
    {
        if (id != device.Id)
        {
            return BadRequest();
        }

        _context.Entry(device).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DeviceExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Devices
    [HttpPost]
    public async Task<ActionResult<Device>> PostDevice(Device device)
    {
        _context.Devices.Add(device);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetDevice", new { id = device.Id }, device);
    }

    // DELETE: api/Devices/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDevice(int id)
    {
        var device = await _context.Devices.FindAsync(id);
        if (device == null)
        {
            return NotFound();
        }

        _context.Devices.Remove(device);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool DeviceExists(int id)
    {
        return _context.Devices.Any(e => e.Id == id);
    }
} 