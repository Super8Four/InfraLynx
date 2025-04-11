using System.ComponentModel.DataAnnotations;

namespace Infralynx.Core.Models;

public class Vlan
{
    public int Id { get; set; }

    [Required]
    [Range(1, 4094)]
    public int VlanId { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
} 