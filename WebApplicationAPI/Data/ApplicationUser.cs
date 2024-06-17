using Microsoft.AspNetCore.Identity;

namespace WebApplicationAPI.Data
{
    public class ApplicationUser :IdentityUser
    {
        public string? Name { get; set; }
    }
}
