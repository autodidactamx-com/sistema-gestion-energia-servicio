using ems_domain.IRepositorio.Proceso;
using ems_domain.IServicio.Configuracion;
using ems_domain.Modelo.Proceso;

namespace ems_service.Servicio.Configuracion;

public class ConfiguracionArranqueServicio : IConfiguracionArranqueServicio
{
    private readonly IConfiguracionArranqueRepositorio _configuracionArranqueRepositorio;

    public ConfiguracionArranqueServicio(IConfiguracionArranqueRepositorio configuracionArranqueRepositorio)
    {
        _configuracionArranqueRepositorio = configuracionArranqueRepositorio;
    }

    public RespuestaCrudModelo Insertar(ConfiguracionArranqueModelo modelo)
    {
        var respuesta = new RespuestaCrudModelo();
        try
        {
            _configuracionArranqueRepositorio.Insertar(modelo: modelo);
            respuesta.EstadoOperacion = true;
            respuesta.MensajeOperacion = "Registro insertado correctamente.";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            respuesta.EstadoOperacion = false;
            respuesta.MensajeOperacion = "Error durante la inserción: " + e.Message;
        }
        return respuesta;
    }

    public RespuestaCrudModelo ModificarPorId(int idConfiguracion, ConfiguracionArranqueModelo modelo)
    {
        var respuesta = new RespuestaCrudModelo();
        try
        {
            _configuracionArranqueRepositorio.ModificarPorId(idConfiguracion: idConfiguracion, modelo: modelo);
            respuesta.EstadoOperacion = true;
            respuesta.MensajeOperacion = "Registro actualizado correctamente.";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            respuesta.EstadoOperacion = false;
            respuesta.MensajeOperacion = "Error durante la actualización: " + e.Message;
        }
        return respuesta;
    }

    public RespuestaCrudModelo EliminarPorId(int idConfiguracion)
    {
        var respuesta = new RespuestaCrudModelo();
        try
        {
            _configuracionArranqueRepositorio.EliminarPorId(idConfiguracion: idConfiguracion);
            respuesta.EstadoOperacion = true;
            respuesta.MensajeOperacion = "Registro eliminado correctamente.";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            respuesta.EstadoOperacion = false;
            respuesta.MensajeOperacion = "Error durante la eliminación: " + e.Message;
        }
        return respuesta;
        
    }

    public ConfiguracionArranqueModelo ObtenerPorId(int idConfiguracion)
    {
        var resultadoConsulta = _configuracionArranqueRepositorio.ObtenerPorId(idConfiguracion: idConfiguracion);
        return resultadoConsulta;
    }
}