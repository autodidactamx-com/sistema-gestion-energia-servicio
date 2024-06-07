using ems_domain.IRepositorio.Proceso;
using ems_domain.Modelo.Proceso;

namespace ems_persistencia.Repositorio.Proceso;

public class MedicionesRepositorio : IMedicionesRepositorio
{
    public void Insertar(MedicionModelo modelo)
    {
        throw new NotImplementedException();
    }

    public void EliminarPorId(DateTime fechaHora)
    {
        throw new NotImplementedException();
    }

    public List<MedicionModelo> ObtenerPorFecha(DateTime fechaIni, DateTime fechaFin)
    {
        throw new NotImplementedException();
    }
}