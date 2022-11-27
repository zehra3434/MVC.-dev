using Microsoft.EntityFrameworkCore;
using MVC.SQLite3.EF.Entities;

namespace MVC.SQLite3.EF.DAL.Concrete.EF
{
    public class NorthwindDbContext:DbContext
    {
        public string Dbpath { get; private set; }
        public DbSet <Employee> Employees{ get; set; }
        public DbSet <Product>  Products{ get; set; }
        public NorthwindDbContext()
        {
            Dbpath = "C:\\Users\\zehra\\Desktop\\Nortwin_TURKCE (1)";


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source={Dbpath}");
        }


    }
}
