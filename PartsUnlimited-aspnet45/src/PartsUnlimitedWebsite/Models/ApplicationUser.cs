using Microsoft.AspNet.Identity.EntityFramework;

namespace PartsUnlimited.Models
{
    public class ApplicationUser : IdentityUser
    {
        // my first change
        public string Name { get; set; }
    }
}