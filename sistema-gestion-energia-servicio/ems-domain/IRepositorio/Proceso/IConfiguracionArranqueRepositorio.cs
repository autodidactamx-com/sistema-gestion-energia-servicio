using ems_domain.Modelo.Proceso;

namespace ems_domain.IRepositorio.Proceso;

public interface IConfiguracionArranqueRepositorio
{
    public void Insertar(ConfiguracionArranqueModelo modelo);
    public void ModificarPorId(int id, ConfiguracionArranqueModelo modelo);
    public void EliminarPorId(int id);
    public void ObtenerPorId(int Id, ConfiguracionArranqueModelo modelo);
}