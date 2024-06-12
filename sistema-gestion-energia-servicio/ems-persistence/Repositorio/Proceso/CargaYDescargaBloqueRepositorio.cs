using ems_domain.IRepositorio.Proceso;
using ems_domain.Modelo.Proceso;

namespace ems_persistencia.Repositorio.Proceso;

public class CargaYDescargaBloqueRepositorio : ICargaYDescargaBloqueRepositorio
{
    private readonly EmsLiteDbContext _context;

    public CargaYDescargaBloqueRepositorio(EmsLiteDbContext context)
    {
        _context = context;
    }

    public void Insertar(CargaYDescargaBloqueModelo modelo)
    {
        var carga = new CargaYDescargaBloque
        {
            dia_semana = modelo.DiaSem,
            estacion = modelo.Estacion,
            tipo = modelo.Tipo,
            hora_final = modelo.HoraFinal,
            hora_inicial = modelo.HoraInicial
        };
        _context.CargaDescargaBloque.Add(carga);
        _context.SaveChanges();
    }

    public void ModificarPorId(int idCarga, CargaYDescargaBloqueModelo modelo)
    {
        var carga = (from config in _context.CargaDescargaBloque
            where config.id == idCarga
            select config).SingleOrDefault();
        if (carga == null) return;
        carga.tipo = modelo.Tipo;
        carga.hora_inicial = modelo.HoraInicial;
        carga.hora_final = modelo.HoraFinal;
        carga.estacion = modelo.Estacion;
        carga.dia_semana = modelo.DiaSem;
        _context.SaveChanges();
    }

    public void EliminarPorId(int idCarga)
    {
        var carga = (from c in _context.CargaDescargaBloque
            where c.id == idCarga
            select c).SingleOrDefault();
        if (carga == null) return;
        _context.CargaDescargaBloque.Remove(carga);
        _context.SaveChanges();
    }

    public CargaYDescargaBloqueModelo ObtenerPorId(int idCarga)
    {
        var carga = (from config in _context.CargaDescargaBloque
            where config.id == idCarga
            select new CargaYDescargaBloqueModelo
            {
                HoraInicial = config.hora_inicial,
                HoraFinal = config.hora_final,
                Estacion = config.estacion,
                DiaSem = config.dia_semana,
                Tipo = config.tipo
            }).SingleOrDefault();
        return carga;
    }

    public List<CargaYDescargaBloqueModelo> ObtenerTodo()
    {
        var cargas = (from config in _context.CargaDescargaBloque
            select new CargaYDescargaBloqueModelo
            {
                HoraInicial = config.hora_inicial,
                HoraFinal = config.hora_final,
                Estacion = config.estacion,
                DiaSem = config.dia_semana,
                Tipo = config.tipo
            }).ToList();
        return cargas;
    }
}