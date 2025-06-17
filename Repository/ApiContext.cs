using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
         : base(options)
        { }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Cars> Carss { get; set; }
        public virtual DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);
            ApiMb.OnModelCreating(builder);
        }
      
    }
}
