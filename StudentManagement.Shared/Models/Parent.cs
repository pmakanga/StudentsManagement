using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.Shared.Models
{
    public class Parent
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? MiddleName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? EmailAddress { get; set; }

        public int GenderId { get; set; }

        public SystemCodeDetail? Gender { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

        [Required]
        public string? Address { get; set; }

        public Guid StudentId { get; set; }

        public Student? Student { get; set; }

        public int ParentTypeId { get; set; }

        public SystemCodeDetail? ParentType { get; set; }

        public DateTime DOB { get; set; }
    }
}
