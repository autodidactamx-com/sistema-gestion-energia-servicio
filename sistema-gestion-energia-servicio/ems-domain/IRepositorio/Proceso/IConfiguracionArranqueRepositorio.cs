using ems_domain.Modelo.Proceso;

namespace ems_domain.IRepositorio.Proceso;

public interface IConfiguracionArranqueRepositorio
{
    public void Insertar(ConfiguracionArranqueModelo modelo);
    public void ModificarPorId(int idConfiguracion, ConfiguracionArranqueModelo modelo);
    public void EliminarPorId(int idConfiguracion);
    public ConfiguracionArranqueModelo ObtenerPorId(int idConfiguracion);
}