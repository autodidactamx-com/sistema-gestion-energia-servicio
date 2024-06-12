using ems_domain.IServicio.Configuracion;
using ems_domain.Modelo.Proceso;
using Microsoft.Extensions.DependencyInjection;

namespace ems_unit_test;

public class EmsTest
{
    public IServiceProvider _container;
    
    [SetUp]
    public void Setup()
    {
        _container = new ConfiguracionServicios().Build();
    }

    [Test]
    public void TestAddConfiguracionArranque()
    {
        var arranqueServicio = _container.GetService<IConfiguracionArranqueServicio>();
        var configuracionModelo = new ConfiguracionArranqueModelo()
        {
            DemandaContratada = 100,
            PorcentajeCargaSegura = 80,
            LimiteDemanda = 200,
            PotenciaBaterias = 50,
            CapacidadBaterias = 100,
            PorcentajeRespaldoEnergia = 70,
            CapacidadBateriaSegura = 90
        };
        var resultadoOperacion = arranqueServicio.Insertar(modelo: configuracionModelo);

        // Asegura que el resultado de la operación es verdadero
        Assert.True(resultadoOperacion.EstadoOperacion);
    }
}