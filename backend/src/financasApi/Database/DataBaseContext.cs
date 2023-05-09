using financasApi.Models;
using Microsoft.EntityFrameworkCore;

namespace financasApi.Database
{
    public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<CadastroConta> CadastroContas { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
    }
}
