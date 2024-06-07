using ems_domain.Modelo.Proceso;

namespace ems_domain.IServicio.Configuracion;

public interface IRangoBloqueEstacionServicio
{
    public void Insertar(RangoBloqueEstacionModelo modelo);
    public void ModificarPorId(int bloque, RangoBloqueEstacionModelo modelo);
    public void EliminarPorId(int bloque);
    public CargaYDescargaBloqueModelo ObtenerPorBloque(int bloque);
}