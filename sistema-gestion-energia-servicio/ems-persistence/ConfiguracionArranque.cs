namespace ems_persistencia;

public class ConfiguracionArranque
{
    public int id { get; set; }
    public double demanda_contratada { get; set; }
    public double porcentaje_carga_segura { get; set; }
    public double limite_demanda { get; set; }
    public double potencia_baterias { get; set; }
    public double capacidad_baterias { get; set; }
    public double porcentaje_respaldo_energía { get; set; }
    public double capacidad_bateria_segura { get; set; }
}
