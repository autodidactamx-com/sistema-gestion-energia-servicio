using ems_domain.Modelo.Proceso;

namespace ems_domain.IRepositorio.Proceso;

public interface IRangoBloqueEstacionRepositorio
{
    public void Insertar(RangoBloqueEstacionModelo modelo);
    public void ModificarPorId(int idBloque, RangoBloqueEstacionModelo modelo);
    public void EliminarPorId(int idBloque);
    public RangoBloqueEstacionModelo ObtenerPorBloque(int idBloque);
}