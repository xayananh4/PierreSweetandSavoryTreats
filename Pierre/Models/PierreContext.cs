using Microsoft.EntityFrameworkCore;

namespace Pierre.Models
{
  public class PierreContext : IdentityDbContext<ApplicationUser>
  {

    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavors { get; set; }

    public PierreContext(DbContextOptions options) : base(options) { }
  }
}