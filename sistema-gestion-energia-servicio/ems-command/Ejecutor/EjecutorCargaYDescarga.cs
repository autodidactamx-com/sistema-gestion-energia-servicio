using ems_command.Modelos;

namespace ems_command.Ejecutor;

public class EjecutorCargaYDescarga
{
    public static int Run(OpcionesCargaYDescarga options)
    {
        Console.WriteLine(options.TipoOperacion);
        Console.WriteLine(options.IdCarga);
        Console.WriteLine(options.Tipo);
        Console.WriteLine(options.HoraInicial);
        Console.WriteLine(options.HoraFinal);
        Console.WriteLine(options.DiaSem);
        return 1;
    }
}