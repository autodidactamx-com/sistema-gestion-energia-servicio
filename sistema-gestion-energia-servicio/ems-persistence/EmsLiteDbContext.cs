using Microsoft.EntityFrameworkCore;

namespace ems_persistencia;

public class EmsLiteDbContext : DbContext
{

    public EmsLiteDbContext()
    {
    }
    
    public EmsLiteDbContext(DbContextOptions<EmsLiteDbContext> options) : base(options) 
    {
    }
    

    public DbSet<ConfiguracionArranque> ConfiguracionArranque { get; set; }
    public DbSet<CargaYDescargaBloque> CargaDescargaBloque { get; set; }
    public DbSet<RangoBloqueEstacion> RangoBloqueEstacion { get; set; }
    
    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=ems-lite.db");
    }*/
}