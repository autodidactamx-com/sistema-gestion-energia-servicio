using ems_domain.Modelo.Proceso;

namespace ems_domain.IRepositorio.Proceso;

public interface IMedicionesRepositorio
{
    public void Insertar(MedicionModelo modelo);
    public void EliminarPorId(DateTime fechaHora);
    public List<MedicionModelo> ObtenerPorFecha(DateTime fechaIni, DateTime fechaFin);
}