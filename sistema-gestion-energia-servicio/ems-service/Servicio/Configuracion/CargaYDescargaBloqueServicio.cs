using ems_domain.IRepositorio.Proceso;
using ems_domain.IServicio.Configuracion;
using ems_domain.Modelo.Proceso;

namespace ems_service.Servicio.Configuracion;

public class CargaYDescargaBloqueServicio : ICargaYDescargaBloqueServicio
{
    private readonly ICargaYDescargaBloqueRepositorio _descargaBloqueRepositorio;

    public CargaYDescargaBloqueServicio(ICargaYDescargaBloqueRepositorio descargaBloqueRepositorio)
    {
        _descargaBloqueRepositorio = descargaBloqueRepositorio;
    }

    public RespuestaCrudModelo Insertar(CargaYDescargaBloqueModelo modelo)
    {
        RespuestaCrudModelo respuesta;
        try
        {
            _descargaBloqueRepositorio.Insertar(modelo: modelo);
            respuesta = new RespuestaCrudModelo { 
                EstadoOperacion = true, 
                MensajeOperacion = "Registro insertado correctamente."
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            respuesta = new RespuestaCrudModelo { 
                EstadoOperacion = false, 
                MensajeOperacion = $"Error durante la inserción: {e.Message}"
            };
        }
        return respuesta;
    }

    public RespuestaCrudModelo ModificarPorId(int idCarga, CargaYDescargaBloqueModelo modelo)
    {
        RespuestaCrudModelo respuesta;
        try
        {
            _descargaBloqueRepositorio.ModificarPorId(idCarga: idCarga, modelo: modelo);
            respuesta = new RespuestaCrudModelo { 
                EstadoOperacion = true, 
                MensajeOperacion = "Registro actualizado correctamente."
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            respuesta = new RespuestaCrudModelo { 
                EstadoOperacion = false, 
                MensajeOperacion = $"Error durante la actualización: {e.Message}"
            };
        }
        return respuesta;
    }

    public RespuestaCrudModelo EliminarPorId(int idCarga)
    {
        RespuestaCrudModelo respuesta;
        try
        {
            _descargaBloqueRepositorio.EliminarPorId(idCarga: idCarga);
            respuesta = new RespuestaCrudModelo { 
                EstadoOperacion = true, 
                MensajeOperacion = "Registro eliminado correctamente."
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            respuesta = new RespuestaCrudModelo { 
                EstadoOperacion = false, 
                MensajeOperacion = $"Error durante la eliminación: {e.Message}"
            };
        }
        return respuesta;
    }

    public CargaYDescargaBloqueModelo ObtenerPorId(int idCarga)
    {
        var resultadoConsulta = _descargaBloqueRepositorio.ObtenerPorId(idCarga: idCarga);
        return resultadoConsulta;
    }

    public List<CargaYDescargaBloqueModelo> ObtenerTodo()
    {
        var resultadoConsulta = _descargaBloqueRepositorio.ObtenerTodo();
        return resultadoConsulta;
    }
}