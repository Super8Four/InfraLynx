using System.ComponentModel.DataAnnotations;

namespace Infralynx.Core.Models;

public class Provider
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    [StringLength(100)]
    public string? ContactEmail { get; set; }

    [StringLength(20)]
    public string? ContactPhone { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
} 