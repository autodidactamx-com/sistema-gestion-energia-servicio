namespace ems_persistencia;

public class CargaYDescargaBloque
{
    public int id { get; set; }
    public string estacion { get; set; }
    public int dia_semana { get; set; }
    public DateTime hora_inicial { get; set; }
    public DateTime hora_final { get; set; }
    public string tipo { get; set; }
}
