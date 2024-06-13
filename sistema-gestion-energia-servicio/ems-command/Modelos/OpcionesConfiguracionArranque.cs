using CommandLine;

namespace ems_command.Modelos;

[Verb("conf-arranque", HelpText = "Configuracion  de arranque")]
public class OpcionesConfiguracionArranque
{
    [Option('t', "tipo-operacion", Required = true, Default = 0, HelpText = "Tipo de Operacion")]
    public string TipoOperacion { get; set; }
    
    [Option('i', "id-configuracion", Required = true, Default = 0, HelpText = "Id Configuracion Arranque")]
    public int IdConfiguracion { get; set; }
    
    [Option('d', "demanda-contratada", Required = true, Default = 0, HelpText = "Demanda Contratada")]
    public double DemandaContratada { get; set; }
    
    [Option('p', "porcentaje-carga-segura", Required = true, Default = 0, HelpText = "Porcentaje Carga Segura")]
    public double PorcentajeCargaSegura { get; set; }
    
    [Option('l', "limite-demanda", Required = true, Default = 0, HelpText = "Limite Demanda")]
    public double LimiteDemanda { get; set; }
    
    [Option('b', "potencia-bateria", Required = true, Default = 0, HelpText = "Potencia Bateria")]
    public double PotenciaBaterias { get; set; }
    
    [Option('c', "capacidad-bateria", Required = true, Default = 0, HelpText = "Capacidad Bateria")]
    public double CapacidadBaterias { get; set; }
    
    [Option('r', "porcentaje-respaldo", Required = true, Default = 0, HelpText = "Porcentaje Respaldo Energia")]
    public double PorcentajeRespaldoEnergia { get; set; }   
    
    [Option('s', "capacidad-bateria-segura", Required = true, Default = 0, HelpText = "Porcentaje Respaldo Energia")]
    public double CapacidadBateriaSegura { get; set; }  
}