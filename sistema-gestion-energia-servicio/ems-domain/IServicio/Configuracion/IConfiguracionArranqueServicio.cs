using ems_domain.Modelo.Proceso;

namespace ems_domain.IServicio.Configuracion;

public interface IConfiguracionArranqueServicio
{
    public RespuestaCrudModelo Insertar(ConfiguracionArranqueModelo modelo);
    public RespuestaCrudModelo ModificarPorId(int idConfiguracion, ConfiguracionArranqueModelo modelo);
    public RespuestaCrudModelo EliminarPorId(int idConfiguracion);
    public ConfiguracionArranqueModelo ObtenerPorId(int idConfiguracion);
}