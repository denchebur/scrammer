using DAL.DatabaseContextDir;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL;

public static class ServiceCollectionExtension
{
    
    public static IServiceCollection ConfigureServices(this IServiceCollection service, IConfiguration config)
    {
        
        config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        service.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer(config.GetConnectionString("defaultConnection")));
        return service;
    }
}