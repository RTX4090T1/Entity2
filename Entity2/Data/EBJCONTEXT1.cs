namespace Entity2;
using Microsoft.EntityFrameworkCore;

//Варіант 13. Спортивні результати
//Таблиця “Athletes”: ім'я спортсмена, вид спорту, результат, медаль.
//Завдання 1: Знайти спортсменів, які здобули медалі у певному виді спорту.
//Завдання 2: Зберегти дані таблиці у xml-файл
public class EBJCONTEXT1
{
    public class EbjContext : DbContext
    {
        public DbSet <Sport> SportResults { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=NITRO\\MSSQLSERVER01;Database=SportDb;Trusted_Connection=True;TrustServerCertificate=true");
        }     
    }

}