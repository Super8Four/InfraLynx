using System.ComponentModel.DataAnnotations;

namespace Infralynx.Core.Models;

public class Rack
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public int SiteId { get; set; }
    public Site? Site { get; set; }

    [Range(1, 100)]
    public int? Units { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
} 