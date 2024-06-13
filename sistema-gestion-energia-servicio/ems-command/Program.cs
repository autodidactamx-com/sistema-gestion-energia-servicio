using CommandLine;
using ems_command.Ejecutor;
using ems_command.Modelos;

class Program
{

    static void Main(string[] args)
    {
        CommandLine.Parser.Default.ParseArguments<OpcionesConfiguracionArranque>(args)
            .MapResult(
                (OpcionesConfiguracionArranque opts) => EjecutorConfiguracionArranque.Run(opts),
                errs => 1);
    }
}