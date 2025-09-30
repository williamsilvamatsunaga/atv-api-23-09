using atv_api_23_09.DataContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace atv_api_23_09.Controllers
{
    [Route("/dados")]
    [ApiController]
    public class DadosEmpresaController : Controller
    {
        private readonly AppDbContext _context;

        public DadosEmpresaController(AppDbContext context)
        {
            _context = context;
        }

        
 
        [HttpGet]
        public async Task<IActionResult> BuscarTodos(
            [FromQuery] string? search)
        {
            var query = _context.DadosEmpresas.AsQueryable();

            if (search is not null)
            {
                query = query.Where(x => x.Cnpj.Contains(search));
            }

            var dados = await query.ToListAsync();

            return Ok(dados);
        }
    }
}
