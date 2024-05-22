using AgencyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AgencyWeb.DAL
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Portofolio> Portofolios { get; set; }

    }
}
