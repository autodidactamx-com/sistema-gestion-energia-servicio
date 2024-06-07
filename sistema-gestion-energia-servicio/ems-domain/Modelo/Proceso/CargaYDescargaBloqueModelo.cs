namespace ems_domain.Modelo.Proceso;

public class CargaYDescargaBloqueModelo
{
    public int Id { get; set; }
    public string Estacion { get; set; }
    public int DiaSem { get; set; }
    public DateTime HoraInicial { get; set; }
    public DateTime HoraFinal { get; set; }
    public string Tipo { get; set; }
}