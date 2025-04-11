using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Infralynx.Core.Models;

public class IPAddress
{
    public int Id { get; set; }

    [Required]
    [RegularExpression(@"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\/([0-9]|[1-2][0-9]|3[0-2]))?$", 
        ErrorMessage = "Invalid IP address format")]
    public string Address { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Status { get; set; } = string.Empty;

    public int? AssignedObjectId { get; set; }
    public string? AssignedObjectType { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public int? VlanId { get; set; }
    public Vlan? Vlan { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
} 