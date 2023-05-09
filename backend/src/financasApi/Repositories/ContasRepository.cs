using financasApi.Database;
using financasApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace financasApi.Repositories
{
    public class ContasRepository : IContasRepository
    {
        private readonly DataBaseContext _db;

        public ContasRepository(DataBaseContext db)
        {
            _db = db;
        }

        public async Task<CadastroConta> Get(int id)
        {
            return await _db.CadastroContas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> Post(CadastroConta conta)
        {
            _db.Add(conta);
            return await _db.SaveChangesAsync();
        }
    }
}
