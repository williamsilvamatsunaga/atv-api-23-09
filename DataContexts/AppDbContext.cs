using atv_api_23_09.Models;
using Microsoft.EntityFrameworkCore;

namespace atv_api_23_09.DataContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DadosEmpresa> DadosEmpresa { get; set; }
    }
}
