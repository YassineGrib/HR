using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.Classes;
using Microsoft.EntityFrameworkCore;

//namespace HR.Classes
//{
//    public class AppDbContext : DbContext
//    {
//        public DbSet<User> Users { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\Database.mdf;Integrated Security=True");
//        }
//    }
//}



namespace HR.Classes
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thinkpad\source\repos\HR\bin\Debug\net8.0-windows\database\database.mdf;Integrated Security=True");
        }
    }
}
