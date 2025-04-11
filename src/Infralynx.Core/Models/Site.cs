using System.ComponentModel.DataAnnotations;

namespace Infralynx.Core.Models;

public class Site
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Status { get; set; } = string.Empty;

    [StringLength(100)]
    public string? Region { get; set; }

    [StringLength(100)]
    public string? Facility { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
} 