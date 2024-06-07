namespace ems_domain.IServicio.ComunicadorModBus;

public interface IComunicadorModbusServicio
{
    public object LecturaMedicion();
    public void EscrituraMedicion();
}