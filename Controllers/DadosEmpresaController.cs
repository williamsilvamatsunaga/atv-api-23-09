using atv_api_23_09.DataContexts;
using atv_api_23_09.Models;
using atv_api_23_09.Models.DadosEmpresaTwo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace atv_api_23_09.Controllers
{
    [Route("/dados")]
    [ApiController]
    public class DadosEmpresaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DadosEmpresaController(AppDbContext context)
        {
            _context = context;
        }

        
 
        [HttpGet]
        public async Task<IActionResult> BuscarTodos(
            [FromQuery] string? RazaoSocial,
            [FromQuery] string? NomeFantasia,
            [FromQuery] string? Cnpj)
        {
            var query = _context.DadosEmpresa.AsQueryable();

            if(RazaoSocial is not null)
            {
                query = query.Where(x => x.RazaoSocial.Contains(RazaoSocial));
            }

            if (NomeFantasia is not null)
            {
                query = query.Where(x => x.NomeFantasia.Contains(NomeFantasia));
            }

            if (Cnpj is not null)
            {
                query = query.Where(x => x.Cnpj.Contains(Cnpj));
            }

            var dados = await query
            .Select(x => new {x.RazaoSocial,
            x.NomeFantasia,
            x.Cnpj,
            x.Telefone,
            x.Email}).ToListAsync();

            return Ok(dados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPorId(int id)
        {
            var dados = await _context.DadosEmpresa.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] DadosEmpresa novaEmpresa)
        {
            var criarDados = new DadosEmpresa()
            {
                RazaoSocial = novaEmpresa.RazaoSocial,
                NomeFantasia = novaEmpresa.NomeFantasia,
                Cnpj = novaEmpresa.Cnpj,
                InscricaoEstadual = novaEmpresa.InscricaoEstadual,
                Telefone = novaEmpresa.Telefone,
                Email = novaEmpresa.Email,
                Cidade = novaEmpresa.Cidade,
                Estado = novaEmpresa.Estado,
                Cep = novaEmpresa.Cep,
                DataCadastro = novaEmpresa.DataCadastro
            };

            await _context.DadosEmpresa.AddAsync(criarDados);
            await _context.SaveChangesAsync();

            return Created("", criarDados);
        }

        [HttpDelete("{cnpj}")]
        public async Task<IActionResult> Remover(string cnpj)
        {
            var remover = await _context.DadosEmpresa.FirstOrDefaultAsync(x => x.Cnpj == cnpj);

            if (remover == null)
            {
                return NotFound();
            }

            _context.DadosEmpresa.Remove(remover);
            await _context.SaveChangesAsync();

            return Ok(remover);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] DadosEmpresaDto atualizarDados)
        {
            var dados = await _context.DadosEmpresa.FirstOrDefaultAsync(x => x.Id == id);

            if (dados is null)
            {
                return NotFound();
            }

            dados.RazaoSocial = atualizarDados.RazaoSocial;
            dados.NomeFantasia = atualizarDados.NomeFantasia;
            dados.Telefone = atualizarDados.Telefone;
            dados.Email = atualizarDados.Email;
            dados.Cidade = atualizarDados.Cidade;
            dados.Estado = atualizarDados.Estado;
            dados.Cep = atualizarDados.Cep;


            _context.DadosEmpresa.Update(dados);
            await _context.SaveChangesAsync();

            return Ok(dados);
    }


    }
}
