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
    
}