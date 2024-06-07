namespace ems_domain.Modelo.Proceso;

public class ConfiguracionArranqueModelo
{
    public int Id { get; set; }
    public double DemandaContratada { get; set; }
    public double PorcentajeCargaSegura { get; set; }
    public double LimiteDemanda { get; set; }
    public double PotenciaBaterías { get; set; }
    public double CapacidadBaterías { get; set; }
    public double PorcentajeRespaldoEnergía { get; set; }
    public double CapacidadBateríaSegura { get; set; }
}