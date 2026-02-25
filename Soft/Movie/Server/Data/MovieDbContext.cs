
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Abc.Soft.Web.Data
{
    public class MovieDbContext(DbContextOptions<MovieDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Abc.Soft.Web.Model.Movie> Movie { get; set; } = default!;
    }
}
