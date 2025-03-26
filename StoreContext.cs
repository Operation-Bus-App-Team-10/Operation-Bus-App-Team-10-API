git checkout -b ef-core
 dotnet new classlib -n Operation-bus-app-team-10.Data
 dotnet sln add */*.csproj
 dotnet add YOUR-PROJECT-NAME.Data/Operation-bus-app-team-10.Data.csproj reference Operation-bus-app-team-10.Domain/Operation-bus-app-team-10.Domain.csproj
 dotnet add Operation-bus-app-team-10.Api/Operation-bus-app-team-10.Api.csproj reference Operation-bus-app-team-10.Data/Operation-bus-app-team-10.Data.csproj
 dotnet restore && dotnet build
 
 dotnet tool install - -global dotnet-ef
 dotnet tool install - -global dotnet-aspnet-codegenerator
 dotnet add package Microsoft.EntityFrameworkCore.Sqlite
 
 using Operation-bus-app-team-10;
 using Microsoft.EntityFrameworkCore;
 
 namespace Operation-bus-app-team-10
 {
   public class StoreContext : DbContext
   {
     public StoreContext(DbContextOptions<StoreContent> options)
       : base(options)
       {  }
 
       public DbSet<Item> Items {get; set; }
       }
     }
