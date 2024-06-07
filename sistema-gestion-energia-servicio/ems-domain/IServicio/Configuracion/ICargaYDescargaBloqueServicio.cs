using ems_domain.Modelo.Proceso;

namespace ems_domain.IServicio.Configuracion;

public interface ICargaYDescargaBloqueServicio
{
    public void Insertar(CargaYDescargaBloqueModelo modelo);
    public void ModificarPorId(int id, CargaYDescargaBloqueModelo modelo);
    public void EliminarPorId(int id);
    public CargaYDescargaBloqueModelo ObtenerPorId(int Id);
    public List<CargaYDescargaBloqueModelo> ObtenerTodo();
}