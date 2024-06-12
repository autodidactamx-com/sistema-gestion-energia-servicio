namespace ems_domain.Modelo.Proceso;

public class RangoBloqueEstacionModelo
{
    public int Id { get; set; }
    public DateTime FechaHoraInicio { get; set; }
    public DateTime FechaHoraFinal { get; set; }
    public string Estacion { get; set; }
}