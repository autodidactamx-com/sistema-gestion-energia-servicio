using ems_domain.IServicio.Configuracion;
using ems_domain.Modelo.Proceso;
using Microsoft.Extensions.DependencyInjection;

namespace ems_unit_test;

public class EmsTestCargaYDescargaBloque
{
    private IServiceProvider _container;
    private ICargaYDescargaBloqueServicio _bloqueServicio;

    
    [SetUp]
    public void Setup()
    {
        _container = new ConfiguracionServicios().Build();
        _bloqueServicio = _container.GetService<ICargaYDescargaBloqueServicio>();
    }

    private CargaYDescargaBloqueModelo CrearCargaYDescargaModelo()
    {
        return new CargaYDescargaBloqueModelo()
        {
           Estacion = "Estacion Test",
           Tipo = "Tipo Test",
           DiaSem = 5,
           HoraFinal = new DateTime(),
           HoraInicial = new DateTime()
        };
    }

    [Test]
    public void TestAddCargaYDescarga()
    {
        var cargaModelo = CrearCargaYDescargaModelo();
        var resultadoOperacion = _bloqueServicio.Insertar(modelo: cargaModelo);
        Assert.True(resultadoOperacion.EstadoOperacion);
    }

    [Test]
    public void TestGetCargaYDescarga()
    {
        var idObtener = 1;
        var actualModel = _bloqueServicio.ObtenerPorId(idCarga: idObtener);
        Assert.NotNull(actualModel); 
    }
    
    [Test]
    public void TestDeleteConfiguracionArranque()
    {
        var idEliminar = 5;
        var resultadoOperacion = _bloqueServicio.EliminarPorId(idCarga: idEliminar);
        Assert.True(resultadoOperacion.EstadoOperacion);
    }
    
    [Test]
    public void TestUpdateCargaYDescarga()
    {
        var cargaModelo = CrearCargaYDescargaModelo();
        var idModificar = 4;
        var resultadoOperacion = _bloqueServicio.ModificarPorId(idCarga: idModificar, 
            modelo: cargaModelo);
        Assert.True(resultadoOperacion.EstadoOperacion);
    }
    
    [Test]
    public void TestGetAllCargaYDescarga()
    {
        var resultadoOperacion = _bloqueServicio.ObtenerTodo();
        Assert.NotNull(resultadoOperacion); 
    }
}