using System.Threading.Tasks;
using financasApi.Database;
using financasApi.Models;
using financasApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace financasApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContasController : ControllerBase
    {
        private ContasRepository _contasRepository;

        public ContasController(DataBaseContext db)
        {
            _contasRepository = new ContasRepository(db);
        }

        [HttpGet("{id}")]
        public async Task<CadastroConta> Get(int id)
        {
            return await _contasRepository.Get(id);
        }

        [HttpPost]
        public async Task<int> Post(CadastroConta conta)
        {
            return await _contasRepository.Post(conta);
        }
    }
}
