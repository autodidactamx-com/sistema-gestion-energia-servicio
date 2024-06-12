using ems_domain.IRepositorio.Proceso;
using ems_domain.IServicio.Configuracion;
using ems_domain.Modelo.Proceso;

namespace ems_service.Servicio.Configuracion;

public class RangoBloqueEstacionServicio : IRangoBloqueEstacionServicio
{
    private readonly IRangoBloqueEstacionRepositorio _estacionRepositorio;

    public RangoBloqueEstacionServicio(IRangoBloqueEstacionRepositorio estacionRepositorio)
    {
        _estacionRepositorio = estacionRepositorio;
    }

    public RespuestaCrudModelo Insertar(RangoBloqueEstacionModelo modelo)
    {
        RespuestaCrudModelo respuesta;
        try
        {
            _estacionRepositorio.Insertar(modelo: modelo);
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

    public RespuestaCrudModelo ModificarPorId(int idBloque, RangoBloqueEstacionModelo modelo)
    {
        RespuestaCrudModelo respuesta;
        try
        {
            _estacionRepositorio.ModificarPorId(idBloque: idBloque, modelo: modelo);
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

    public RespuestaCrudModelo EliminarPorId(int idBloque)
    {
        RespuestaCrudModelo respuesta;
        try
        {
            _estacionRepositorio.EliminarPorId(idBloque: idBloque);
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

    public RangoBloqueEstacionModelo ObtenerPorBloque(int idBloque)
    {
        var resultadoConsulta = _estacionRepositorio.ObtenerPorBloque(idBloque: idBloque);
        return resultadoConsulta;
    }
}