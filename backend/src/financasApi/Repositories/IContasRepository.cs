using financasApi.Models;
using System.Threading.Tasks;

namespace financasApi.Repositories
{
    public interface IContasRepository
    {
        public Task<CadastroConta> Get(int id);
        public Task<int> Post(CadastroConta conta);
    }
}
