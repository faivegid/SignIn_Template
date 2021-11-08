using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SiginIn_Template.Data
{
    public class AppContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }
    }
}
