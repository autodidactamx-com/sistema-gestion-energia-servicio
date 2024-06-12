using ems_domain.Modelo.Proceso;

namespace ems_domain.IServicio.Configuracion;

public interface IConfiguracionArranqueServicio
{
    public RespuestaCrudModelo Insertar(ConfiguracionArranqueModelo modelo);
    public void ModificarPorId(int id, ConfiguracionArranqueModelo modelo);
    public void EliminarPorId(int id);
    public ConfiguracionArranqueModelo ObtenerPorId(int Id);
}