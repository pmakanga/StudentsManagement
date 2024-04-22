
using System.ComponentModel.DataAnnotations;


namespace StudentsManagement.Shared.Models
{
    public class Country
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Code { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
