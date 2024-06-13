using ems_command.Modelos;

namespace ems_command.Ejecutor;

public class EjecutorRangoBloque
{
    public static int Run(OpcionesRangoBloque options)
    {
        Console.WriteLine(options.TipoOperacion);
        Console.WriteLine(options.IdRango);
        Console.WriteLine(options.Estacion);
        Console.WriteLine(options.FechaHoraFinal);
        Console.WriteLine(options.FechaHoraInicio);
        return 1;
    }
}