using ems_domain.IRepositorio.Proceso;
using ems_domain.Modelo.Proceso;

namespace ems_persistencia.Repositorio.Proceso;

public class RangoBloqueEstacionRepositorio : IRangoBloqueEstacionRepositorio
{
    private readonly EmsLiteDbContext _context;

    public RangoBloqueEstacionRepositorio(EmsLiteDbContext context)
    {
        _context = context;
    }

    public void Insertar(RangoBloqueEstacionModelo modelo)
    {
        var rangoBloque = new RangoBloqueEstacion()
        {
            bloque = modelo.Bloque,
            estacion = modelo.Estacion,
            hora_final = modelo.FechaHoraFinal,
            hora_inicial = modelo.FechaHoraInicio
        };
        _context.RangoBloqueEstacion.Add(rangoBloque);
        _context.SaveChanges();
    }

    public void ModificarPorId(int idBloque, RangoBloqueEstacionModelo modelo)
    {
        var rangoBloque = (from config in _context.RangoBloqueEstacion
            where config.bloque == idBloque
            select config).SingleOrDefault();
        if (rangoBloque == null) return;
        rangoBloque.estacion = modelo.Estacion;
        rangoBloque.hora_inicial = modelo.FechaHoraInicio;
        rangoBloque.hora_final = modelo.FechaHoraFinal;
        _context.SaveChanges();
    }

    public void EliminarPorId(int idBloque)
    {
        var rangoBloque = (from c in _context.RangoBloqueEstacion
            where c.bloque == idBloque
            select c).SingleOrDefault();
        if (rangoBloque == null) return;
        _context.RangoBloqueEstacion.Remove(rangoBloque);
        _context.SaveChanges();
    }

    public RangoBloqueEstacionModelo ObtenerPorBloque(int idBloque)
    {
        var configuracion = (from config in _context.RangoBloqueEstacion
            where config.bloque == idBloque
            select new RangoBloqueEstacionModelo()
            {
                Bloque = config.bloque,
                FechaHoraInicio = config.hora_inicial,
                FechaHoraFinal = config.hora_final,
                Estacion = config.estacion
            }).SingleOrDefault();
        return configuracion;
    }
}