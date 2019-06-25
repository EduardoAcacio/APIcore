using Microsoft.EntityFrameworkCore;

namespace APIcore.API.Models
{
    public class ApiDBContext : DbContext
    {
        public ApiDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}