namespace ems_domain.IServicio.ComunicadorModBus;

public interface IExtraccionMedicionesServicio
{
    public object LecturaMedicion();
    public void EscrituraMedicion();
}