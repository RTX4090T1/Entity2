namespace Entity2;
using Microsoft.EntityFrameworkCore;
public class EBJCONTEXT1
{
    public class EbjContext : DbContext
    {
        public DbSet<Productt> Students { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=NITRO\\MSSQLSERVER01;Database=EBJ12;Trusted_Connection=True;TrustServerCertificate=true");
        }
    }
}
