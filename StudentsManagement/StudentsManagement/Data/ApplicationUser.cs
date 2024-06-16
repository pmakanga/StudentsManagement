using Microsoft.AspNetCore.Identity;

namespace StudentsManagement.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string FullName => $"{FirstName} {MiddleName} {LastName}";
        public bool IsActive { get; set; } = true;
        public DateTime DeactivatedOn { get; set; }
        public DateTime? LastActivityDate { get; set; }
    }

}
