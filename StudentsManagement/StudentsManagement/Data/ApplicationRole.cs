using Microsoft.AspNetCore.Identity;

namespace StudentsManagement.Data
{
    public class ApplicationRole : IdentityRole
    {
        public string? Description { get; set; }
        public string? CreatedById { get; set; }
        public ApplicationUser? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? SupervisedById { get; set; }
        public ApplicationUser? SupervisedBy { get; set; }
    }
}
