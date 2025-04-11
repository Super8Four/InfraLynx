using System.ComponentModel.DataAnnotations;

namespace Infralynx.Core.Models;

public class Device
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string DeviceType { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Status { get; set; } = string.Empty;

    [Required]
    public int SiteId { get; set; }
    public Site? Site { get; set; }

    public int? RackId { get; set; }
    public Rack? Rack { get; set; }

    public int? Position { get; set; }

    [Required]
    [StringLength(50)]
    public string Role { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
} 