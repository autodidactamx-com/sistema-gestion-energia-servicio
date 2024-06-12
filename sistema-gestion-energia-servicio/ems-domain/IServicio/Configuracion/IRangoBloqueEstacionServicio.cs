using ems_domain.Modelo.Proceso;

namespace ems_domain.IServicio.Configuracion;

public interface IRangoBloqueEstacionServicio
{
    public RespuestaCrudModelo Insertar(RangoBloqueEstacionModelo modelo);
    public RespuestaCrudModelo ModificarPorId(int idBloque, RangoBloqueEstacionModelo modelo);
    public RespuestaCrudModelo EliminarPorId(int idBloque);
    public RangoBloqueEstacionModelo ObtenerPorBloque(int idBloque);
}