using ems_domain.IRepositorio.Proceso;
using ems_domain.Modelo.Proceso;

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
    }

    public void ModificarPorId(int idConfiguracion, ConfiguracionArranqueModelo modelo)
    {
        var configuracion = (from config in _context.ConfiguracionArranque
            where config.id == idConfiguracion
            select config).SingleOrDefault();
        if (configuracion == null) return;
        configuracion.capacidad_bateria_segura = modelo.CapacidadBateriaSegura;
        configuracion.capacidad_baterias = modelo.CapacidadBaterias;
        configuracion.demanda_contratada = modelo.DemandaContratada;
        configuracion.limite_demanda = modelo.LimiteDemanda;
        configuracion.porcentaje_carga_segura = modelo.PorcentajeCargaSegura;
        configuracion.porcentaje_respaldo_energía = modelo.PorcentajeRespaldoEnergia;
        configuracion.potencia_baterias = modelo.PotenciaBaterias;
        _context.SaveChanges();
    }

    public void EliminarPorId(int idConfiguracion)
    {
        var configuracion = (from c in _context.ConfiguracionArranque
            where c.id == idConfiguracion
            select c).SingleOrDefault();
        if (configuracion == null) return;
        _context.ConfiguracionArranque.Remove(configuracion);
        _context.SaveChanges();
    }

    public ConfiguracionArranqueModelo ObtenerPorId(int idConfiguracion)
    {
        var configuracion = (from config in _context.ConfiguracionArranque
            where config.id == idConfiguracion
            select new ConfiguracionArranqueModelo
            {
                Id = config.id,
                CapacidadBateriaSegura = config.capacidad_bateria_segura,
                CapacidadBaterias = config.capacidad_baterias,
                DemandaContratada = config.demanda_contratada,
                LimiteDemanda = config.limite_demanda,
                PorcentajeCargaSegura = config.porcentaje_carga_segura,
                PorcentajeRespaldoEnergia = config.porcentaje_respaldo_energía,
                PotenciaBaterias = config.potencia_baterias
            }).SingleOrDefault();
        
        return configuracion;
    }
}