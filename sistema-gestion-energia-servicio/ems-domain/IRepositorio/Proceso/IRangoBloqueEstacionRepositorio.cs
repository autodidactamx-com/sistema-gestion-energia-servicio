using ems_domain.Modelo.Proceso;

namespace ems_domain.IRepositorio.Proceso;

public interface IRangoBloqueEstacionRepositorio
{
    public void Insertar(RangoBloqueEstacionModelo modelo);
    public void ModificarPorId(int bloque, RangoBloqueEstacionModelo modelo);
    public void EliminarPorId(int bloque);
    public CargaYDescargaBloqueModelo ObtenerPorBloque(int bloque);
}