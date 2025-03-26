using Mircosoft.EntityFrameworkCore;
using Mircosoft.EntityFrameworkCore.Design;

namespace Operation.Bus-App-Team-10-API.Domain;

public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
{

  public StoreContext CreateDbContext(string[] args)
  {
      var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();

      optionsBuilder.UseSqlite("Data source=../Regristrar.sqlite");

      return new StoreContext(optionsBuilder.Options);

      }
      }
      
