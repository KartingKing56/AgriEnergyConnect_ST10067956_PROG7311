using System.ComponentModel.DataAnnotations;

namespace AgriEnergyConnect.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public int EmployeeNumber { get; set; }

        [Required]
        public string? Position { get; set; } // determine if it's a employee or admin
    }
}