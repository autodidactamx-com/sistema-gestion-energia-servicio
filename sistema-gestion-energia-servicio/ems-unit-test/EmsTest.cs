using ems_domain.IServicio.Configuracion;
using ems_domain.Modelo.Proceso;
using Microsoft.Extensions.DependencyInjection;

namespace ems_unit_test;

public class EmsTest
{
    private IServiceProvider _container;
    private IConfiguracionArranqueServicio _arranqueServicio;

    
    [SetUp]
    public void Setup()
    {
        _container = new ConfiguracionServicios().Build();
        _arranqueServicio = _container.GetService<IConfiguracionArranqueServicio>();
    }
    
    private ConfiguracionArranqueModelo CrearConfiguracionModelo()
    {
        return new ConfiguracionArranqueModelo()
        {
            DemandaContratada = 100,
            PorcentajeCargaSegura = 80,
            LimiteDemanda = 200,
            PotenciaBaterias = 50,
            CapacidadBaterias = 100,
            PorcentajeRespaldoEnergia = 70,
            CapacidadBateriaSegura = 90
        };
    }

    [Test]
    public void TestAddConfiguracionArranque()
    {
        var configuracionModelo = CrearConfiguracionModelo();
        var resultadoOperacion = _arranqueServicio.Insertar(modelo: configuracionModelo);
        Assert.True(resultadoOperacion.EstadoOperacion);
    }

    [Test]
    public void TestGetConfiguracionArranque()
    {
        var idObtener = 1;
        var actualModel = _arranqueServicio.ObtenerPorId(idConfiguracion: idObtener);
        Assert.NotNull(actualModel); 
    }
    
    [Test]
    public void TestDeleteConfiguracionArranque()
    {
        var idEliminar = 5;
        var resultadoOperacion = _arranqueServicio.EliminarPorId(idConfiguracion: idEliminar);
        Assert.True(resultadoOperacion.EstadoOperacion);
    }
    
    [Test]
    public void TestUpdateConfiguracionArranque()
    {
        var configuracionModelo = CrearConfiguracionModelo();
        var idModificar = 4;
        var resultadoOperacion = _arranqueServicio.ModificarPorId(idConfiguracion: idModificar, 
            modelo: configuracionModelo);
        Assert.True(resultadoOperacion.EstadoOperacion);
    }
}