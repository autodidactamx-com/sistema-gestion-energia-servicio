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

    [Test]
    public void TestGetConfiguracionArranque()
    {
        var arranqueServicio = _container.GetService<IConfiguracionArranqueServicio>();
        var idObtener = 1;
        var actualModel = arranqueServicio.ObtenerPorId(idConfiguracion: idObtener);
        Assert.NotNull(actualModel); 
    }
    
    [Test]
    public void TestDeleteConfiguracionArranque()
    {
        var arranqueServicio = _container.GetService<IConfiguracionArranqueServicio>();
        var idEliminar = 5;
        var resultadoOperacion = arranqueServicio.EliminarPorId(idConfiguracion: idEliminar);
        Assert.True(resultadoOperacion.EstadoOperacion);
    }
    
    [Test]
    public void TestUpdateConfiguracionArranque()
    {
        var arranqueServicio = _container.GetService<IConfiguracionArranqueServicio>();
        var configuracionModelo = new ConfiguracionArranqueModelo()
        {
            DemandaContratada = 200,
            PorcentajeCargaSegura = 160,
            LimiteDemanda = 400,
            PotenciaBaterias = 100,
            CapacidadBaterias = 200,
            PorcentajeRespaldoEnergia = 140,
            CapacidadBateriaSegura = 180
        };
        var idModificar = 4;
        var resultadoOperacion = arranqueServicio.ModificarPorId(idConfiguracion: idModificar, 
            modelo: configuracionModelo);

        // Asegura que el resultado de la operación es verdadero
        Assert.True(resultadoOperacion.EstadoOperacion);
    }
}