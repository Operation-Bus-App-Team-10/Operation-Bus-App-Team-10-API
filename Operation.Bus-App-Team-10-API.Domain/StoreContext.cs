using Jet.Piranha.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Operation.Bus_App_Team_10_API.Domain;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options)
      : base(options)
      {}

      public DbSet<Order> Orders { get; set; }
}
