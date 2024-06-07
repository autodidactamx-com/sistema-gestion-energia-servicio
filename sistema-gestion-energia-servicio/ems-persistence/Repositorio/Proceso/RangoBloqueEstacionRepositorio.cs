using ems_domain.IRepositorio.Proceso;
using ems_domain.Modelo.Proceso;

namespace ems_persistencia.Repositorio.Proceso;

public class RangoBloqueEstacionRepositorio : IRangoBloqueEstacionRepositorio
{
    public void Insertar(RangoBloqueEstacionModelo modelo)
    {
        throw new NotImplementedException();
    }

    public void ModificarPorId(int bloque, RangoBloqueEstacionModelo modelo)
    {
        throw new NotImplementedException();
    }

    public void EliminarPorId(int bloque)
    {
        throw new NotImplementedException();
    }

    public CargaYDescargaBloqueModelo ObtenerPorBloque(int bloque)
    {
        throw new NotImplementedException();
    }
}