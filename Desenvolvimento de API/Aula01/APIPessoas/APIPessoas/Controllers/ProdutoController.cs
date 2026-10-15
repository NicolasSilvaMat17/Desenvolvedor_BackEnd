using Microsoft.AspNetCore.Mvc;

namespace APIPessoas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        

        [HttpGet("ListarProdutos")]
        public IActionResult ListarProdutos()
        {
            return Ok("Método ListarProdutos funcionou ");
        }
    }
}
    
