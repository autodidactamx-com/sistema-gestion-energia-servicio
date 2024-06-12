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

    public void ModificarPorId(int id, ConfiguracionArranqueModelo modelo)
    {
        throw new NotImplementedException();
    }

    public void EliminarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public ConfiguracionArranqueModelo ObtenerPorId(int Id)
    {
        throw new NotImplementedException();
    }
}