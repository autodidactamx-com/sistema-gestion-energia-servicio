using ems_domain.Modelo.Proceso;

namespace ems_domain.IRepositorio.Proceso;

public interface ICargaYDescargaBloqueRepositorio
{
    public void Insertar(CargaYDescargaBloqueModelo modelo);
    public void ModificarPorId(int idCarga, CargaYDescargaBloqueModelo modelo);
    public void EliminarPorId(int idCarga);
    public CargaYDescargaBloqueModelo ObtenerPorId(int idCarga);
    public List<CargaYDescargaBloqueModelo> ObtenerTodo();
}