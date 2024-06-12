using ems_domain.IRepositorio.Proceso;
using ems_domain.IServicio.ComunicadorModBus;
using ems_domain.IServicio.Configuracion;
using ems_domain.IServicio.Despacho;
using ems_domain.IServicio.Mediciones;
using ems_persistencia;
using ems_persistencia.Repositorio.Proceso;
using ems_service.Servicio.ComunicadorModBus;
using ems_service.Servicio.Configuracion;
using ems_service.Servicio.Despacho;
using ems_service.Servicio.Mediciones;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ems_unit_test;

public class ConfiguracionServicios
{
    public IServiceProvider Build()
    {
        var configurationBuilder = GetBuilder();
        var serviceCollection = new ServiceCollection();
        ConfigureServicesDbSql(configurationBuilder: configurationBuilder, serviceCollection: serviceCollection);
        ConfigureServicesDom(serviceCollection: serviceCollection);
        ConfigureServicesPer(serviceCollection: serviceCollection);
        return serviceCollection.BuildServiceProvider();
    }

    private void ConfigureServicesDbSql(IConfiguration configurationBuilder, ServiceCollection serviceCollection)
    {
        var connectionStrings = new Dictionary<String, String>
        {
            {
                "DataConnectionEmsLite",
                configurationBuilder.GetValue<string>("ConnectionStrings:DataConnectionEmsLite")!
            },
        };
        
        string dataConnectionEmsLite = connectionStrings["DataConnectionEmsLite"];

        serviceCollection.AddDbContext<EmsLiteDbContext>(options =>
            options.UseSqlite(connectionString: dataConnectionEmsLite));
    }

    private void ConfigureServicesDom(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IComunicadorModbusServicio, ComunicadorModbusServicio>();
        serviceCollection.AddScoped<ICargaYDescargaBloqueServicio, CargaYDescargaBloqueServicio>();
        serviceCollection.AddScoped<IConfiguracionArranqueServicio, ConfiguracionArranqueServicio>();
        serviceCollection.AddScoped<IRangoBloqueEstacionServicio, RangoBloqueEstacionServicio>();
        serviceCollection.AddScoped<IDespachoEmsServicio, DespachoEmsServicio>();
        serviceCollection.AddScoped<IExtraccionMedicionesServicio, ExtraccionMedicionesServicio>();
    }

    private void ConfigureServicesPer(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICargaYDescargaBloqueRepositorio, CargaYDescargaBloqueRepositorio>();
        serviceCollection.AddScoped<IConfiguracionArranqueRepositorio, ConfiguracionArranqueRepositorio>();
        serviceCollection.AddScoped<IMedicionesRepositorio, MedicionesRepositorio>();
        serviceCollection.AddScoped<IRangoBloqueEstacionRepositorio, RangoBloqueEstacionRepositorio>();
    }

    private IConfiguration GetBuilder()
    {
        var builder = new ConfigurationBuilder().AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "Properties", "launchSettings.json"));
        var configurationBuilder = builder.AddEnvironmentVariables().Build();
        var enviroment = configurationBuilder["profiles:ExpEcdMemPrueUnit:environmentVariables:ASPNETCORE_ENVIRONMENT"];
        var appsettings = enviroment.Equals("Production") ? "appsettings.json" : $"appsettings.{enviroment}.json";

        var builderC = new ConfigurationBuilder()
            .AddJsonFile(appsettings, optional: true, reloadOnChange: true);

        return builderC.Build();
    }
}