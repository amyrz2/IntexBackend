using Microsoft.EntityFrameworkCore;

namespace IntexDatabaseConnection.Models
{
    public class MyDatabaseContext : DbContext
    {

        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options): base(options) { }
        
        public DbSet<Frontend> Burials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=database-blake.cyqmvash8zhe.us-east-2.rds.amazonaws.com;Port=5432;Database=mummies_test;User Id=intex;Password=Superman2000;");
            }
        }


    }
}

// CONFIGURE THIS TO MATCH THE DATA CONTAINED IN THE POSTGRESQL DATABASE
