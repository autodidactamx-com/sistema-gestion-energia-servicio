using CommandLine;

namespace ems_command.Modelos;

[Verb("conf-carga-descarga", HelpText = "Carga y Descarga")]
public class OpcionesCargaYDescarga
{
    [Option('t', "tipo-operacion", Required = true, Default = 0, HelpText = "Tipo de Operacion")]
    public string TipoOperacion { get; set; }

    [Option('i', "id-carga", Required = true, Default = 0, HelpText = "Id Carga Descarga")]
    public int IdCarga { get; set; }

    [Option('e', "estacion", Required = true, Default = 0, HelpText = "Estacion")]
    public string Estacion { get; set; }

    [Option('d', "dia-semana", Required = true, Default = 0, HelpText = "Dia Semana")]
    public int DiaSem { get; set; }

    [Option('o', "hora-inicial", Required = true, Default = 0, HelpText = "Hora Inicial")]
    public DateTime HoraInicial { get; set; }

    [Option('r', "hora-final", Required = true, Default = 0, HelpText = "Hora Final")]
    public DateTime HoraFinal { get; set; }

    [Option('p', "tipo", Required = true, Default = 0, HelpText = "Tipo")]
    public string Tipo { get; set; }
}