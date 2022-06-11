using Microsoft.EntityFrameworkCore;

namespace WebApplication1.ModelsORM
{
    public class SiemensContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

            {
            optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database =MVCV1 ; Trusted_Connection = True;");

        }

        public DbSet<Suppliers> Suppliers { get; set; }

        public DbSet<Product> Products { get; set; }



    }
}
