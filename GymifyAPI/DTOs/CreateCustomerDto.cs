using System.ComponentModel.DataAnnotations;

namespace GymifyAPI.DTOs;

public class CreateCustomerDto
{
    [Required]
    [StringLength(100)]
    public string FullName { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Phone]
    public string PhoneNumber { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }
}
