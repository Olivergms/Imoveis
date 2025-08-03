using Domain.Repositories;
using Domain.Services;
using Infra.Data.Context;
using Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;

namespace CrossCutting.DependencyInjection;

public static class NativeInjectorBootStrapper
{
    public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
    {
        var config = configuration["ConnectionStrings:WebApiDataBase"];
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(configuration.GetConnectionString("WebApiDataBase")));


        services.AddScoped<IProprietarioRepository, ProprietarioRepository>();
        services.AddScoped<IProprietarioService, ProprietarioService>();

        services.AddScoped<IImovelRepository, ImovelRepository>();
        services.AddScoped<IImovelService, ImovelService>();
    }

}
