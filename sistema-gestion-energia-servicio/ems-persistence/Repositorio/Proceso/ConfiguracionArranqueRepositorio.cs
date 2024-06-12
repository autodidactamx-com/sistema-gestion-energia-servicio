using ems_domain.IRepositorio.Proceso;
using ems_domain.Modelo.Proceso;
using Microsoft.EntityFrameworkCore;

namespace ems_persistencia.Repositorio.Proceso;

public class ConfiguracionArranqueRepositorio : IConfiguracionArranqueRepositorio
{
    private readonly EmsLiteDbContext _context; 

    public ConfiguracionArranqueRepositorio(EmsLiteDbContext context)
    {
        _context = context; 
    }

    public void Insertar(ConfiguracionArranqueModelo modelo)
    {
        var configuracion = new ConfiguracionArranque
        {
            capacidad_bateria_segura = modelo.CapacidadBateriaSegura,
            capacidad_baterias = modelo.CapacidadBaterias,
            demanda_contratada = modelo.DemandaContratada,
            limite_demanda = modelo.LimiteDemanda,
            porcentaje_carga_segura = modelo.PorcentajeCargaSegura,
            porcentaje_respaldo_energía = modelo.PorcentajeRespaldoEnergia,
            potencia_baterias = modelo.PotenciaBaterias
        };
        _context.ConfiguracionArranque.Add(configuracion);
        _context.SaveChanges();
        
        var configuraciones = _context.ConfiguracionArranque.ToList();
        foreach (var p in configuraciones)
        {
            Console.WriteLine($"ID: {p.id}");
        }
    }

    public void ModificarPorId(int id, ConfiguracionArranqueModelo modelo)
    {
        throw new NotImplementedException();
    }

    public void EliminarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public void ObtenerPorId(int Id, ConfiguracionArranqueModelo modelo)
    {
        throw new NotImplementedException();
    }
}