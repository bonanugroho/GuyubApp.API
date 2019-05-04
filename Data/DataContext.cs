using GuyubApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GuyubApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) {}

        public DbSet<RW> RWs { get; set; }
        public DbSet<RT> RTs { get; set; }
        public DbSet<Blok> Bloks { get; set; }
        public DbSet<Rumah> Rumahs { get; set; }
        
    }
}