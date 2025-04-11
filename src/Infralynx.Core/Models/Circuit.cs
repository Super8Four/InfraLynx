using System.ComponentModel.DataAnnotations;

namespace Infralynx.Core.Models;

public class Circuit
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Cid { get; set; } = string.Empty;

    [Required]
    public int ProviderId { get; set; }
    public Provider? Provider { get; set; }

    [Required]
    [StringLength(50)]
    public string Type { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Status { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
} 