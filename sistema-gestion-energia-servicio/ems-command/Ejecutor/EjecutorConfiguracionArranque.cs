using ems_command.Modelos;

namespace ems_command.Ejecutor;

public class EjecutorConfiguracionArranque
{
    public static int Run(OpcionesConfiguracionArranque options)
    {
        Console.WriteLine(options.TipoOperacion);
        Console.WriteLine(options.IdConfiguracion);
        Console.WriteLine(options.DemandaContratada);
        Console.WriteLine(options.PotenciaBaterias);
        Console.WriteLine(options.CapacidadBaterias);
        Console.WriteLine(options.LimiteDemanda);
        Console.WriteLine(options.CapacidadBateriaSegura);
        Console.WriteLine(options.PorcentajeCargaSegura);
        Console.WriteLine(options.PorcentajeRespaldoEnergia);
        return 1;
    }
}