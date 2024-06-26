﻿using System.ComponentModel.DataAnnotations;

namespace StudentsManagement.Shared.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? StudentNo { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? MiddleName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? EmailAddress { get; set; }

        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        [Required]
        public string? Address { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public Guid CountryId { get; set; }
        public Country? Country { get; set; }

        public int GenderId { get; set; }

        public SystemCodeDetail? Gender { get; set; }
        [Required]
        public DateTime DOB { get; set; }

    }
}
