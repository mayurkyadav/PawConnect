using Microsoft.AspNetCore.Identity;

namespace PawConnect.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
        public string UsernameHandle { get; set; } = string.Empty; // e.g. @mayur
    }
}
