using Microsoft.AspNetCore.Mvc;

namespace APIPessoas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string texto = "API funcionou";
            return Ok(texto);
        }

        [HttpGet("Home1")]
        public IActionResult Index1()
        {
            string texto = "API funcionou 1";
            return Ok(texto);
        }
    }
}
