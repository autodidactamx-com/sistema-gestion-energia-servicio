namespace ems_domain.Modelo.Proceso;

public class ConfiguracionArranqueModelo
{
    public int Id { get; set; }
    public double DemandaContratada { get; set; }
    public double PorcentajeCargaSegura { get; set; }
    public double LimiteDemanda { get; set; }
    public double PotenciaBaterias { get; set; }
    public double CapacidadBaterias { get; set; }
    public double PorcentajeRespaldoEnergia { get; set; }
    public double CapacidadBateriaSegura { get; set; }
}