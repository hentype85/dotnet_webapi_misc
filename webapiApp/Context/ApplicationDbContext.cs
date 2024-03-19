using Microsoft.EntityFrameworkCore;
using webapiApp.Models;

namespace webapiApp.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
