using CommandLine;

namespace ems_command.Modelos;

[Verb("conf-rango-bloque", HelpText = "Rango Bloque Estacion")]
public class OpcionesRangoBloque
{
    [Option('t', "tipo-operacion", Required = true, Default = 0, HelpText = "Tipo de Operacion")]
    public string TipoOperacion { get; set; }

    [Option('i', "id-rango", Required = true, Default = 0, HelpText = "Id Rango Bloque")]
    public int IdRango { get; set; }

    [Option('e', "estacion", Required = true, Default = 0, HelpText = "Estacion")]
    public string Estacion { get; set; }

    [Option('o', "hora-inicial", Required = true, Default = 0, HelpText = "Hora Inicial")]
    public DateTime FechaHoraInicio { get; set; }

    [Option('r', "hora-final", Required = true, Default = 0, HelpText = "Hora Final")]
    public DateTime FechaHoraFinal { get; set; }
}