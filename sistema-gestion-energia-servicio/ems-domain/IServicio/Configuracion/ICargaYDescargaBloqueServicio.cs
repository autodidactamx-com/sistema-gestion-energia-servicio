using ems_domain.Modelo.Proceso;

namespace ems_domain.IServicio.Configuracion;

public interface ICargaYDescargaBloqueServicio
{
    public RespuestaCrudModelo Insertar(CargaYDescargaBloqueModelo modelo);
    public RespuestaCrudModelo ModificarPorId(int idCarga, CargaYDescargaBloqueModelo modelo);
    public RespuestaCrudModelo EliminarPorId(int idCarga);
    public CargaYDescargaBloqueModelo ObtenerPorId(int idCarga);
    public List<CargaYDescargaBloqueModelo> ObtenerTodo();
}