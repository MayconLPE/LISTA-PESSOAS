using lista_pessoas_api.Models;
using Microsoft.EntityFrameworkCore;

namespace lista_pessoas_api.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }

}