using ems_domain.IServicio.Configuracion;
using ems_domain.Modelo.Proceso;
using Microsoft.Extensions.DependencyInjection;

namespace ems_unit_test;

public class EmsTestRangoBloqueEstacion
{
    private IServiceProvider _container;
    private IRangoBloqueEstacionServicio _estacionServicio;

    
    [SetUp]
    public void Setup()
    {
        _container = new ConfiguracionServicios().Build();
        _estacionServicio = _container.GetService<IRangoBloqueEstacionServicio>();
    }

    private RangoBloqueEstacionModelo CrearRangoBloqueEstacionModelo()
    {
        return new RangoBloqueEstacionModelo()
        {
           Estacion = "Estacion Test",
           Id = 1,
           FechaHoraFinal = new DateTime(),
           FechaHoraInicio = new DateTime()
        };
    }

    [Test]
    public void TestAddCargaYDescarga()
    {
        var estacionModelo = CrearRangoBloqueEstacionModelo();
        var resultadoOperacion = _estacionServicio.Insertar(modelo: estacionModelo);
        Assert.True(resultadoOperacion.EstadoOperacion);
    }

    [Test]
    public void TestGetCargaYDescarga()
    {
        var idObtener = 1;
        var actualModel = _estacionServicio.ObtenerPorBloque(idBloque: idObtener);
        Assert.NotNull(actualModel); 
    }
    
    [Test]
    public void TestDeleteConfiguracionArranque()
    {
        var idEliminar = 5;
        var resultadoOperacion = _estacionServicio.EliminarPorId(idBloque: idEliminar);
        Assert.True(resultadoOperacion.EstadoOperacion);
    }
    
    [Test]
    public void TestUpdateCargaYDescarga()
    {
        var estacionModelo = CrearRangoBloqueEstacionModelo();
        var idModificar = 4;
        var resultadoOperacion = _estacionServicio.ModificarPorId(idBloque: idModificar, 
            modelo: estacionModelo);
        Assert.True(resultadoOperacion.EstadoOperacion);
    }
}