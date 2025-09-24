using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace atv_api_23_09.Controllers
{
    [Route("dados")]
    [ApiController]
    public class DadosEmpresaController
    {
        [HttpGet]
        public async Task<IActionResult> BuscarTodos()
        {
            var dadosEmpresa = await 
        }
    }
}
