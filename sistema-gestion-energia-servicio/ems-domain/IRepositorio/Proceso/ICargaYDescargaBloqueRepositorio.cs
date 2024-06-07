using ems_domain.Modelo.Proceso;

namespace ems_domain.IRepositorio.Proceso;

public interface ICargaYDescargaBloqueRepositorio
{
    public void Insertar(CargaYDescargaBloqueModelo modelo);
    public void ModificarPorId(int id, CargaYDescargaBloqueModelo modelo);
    public void EliminarPorId(int id);
    public CargaYDescargaBloqueModelo ObtenerPorId(int Id);
    public List<CargaYDescargaBloqueModelo> ObtenerTodo();
}