using Banco.Classes.Models.Entidades;
using Banco.Classes.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Banco.Classes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("aplication/json")]
    public class ContasController : ControllerBase
    {
        RepositorioContas rep = new RepositorioContas();
        /// <summary>
        /// Lista todas as contas cadastradas no banco de dados.
        /// </summary>
        /// <remarks>Não é necessário passar nenhum parâmetro para essa requisição.Retorna uma lista vazia se não houver registros.</remarks>
        /// <returns>Lista de contas</returns>
        /// <response code ="200">Lista retornada com sucesso</response>
        // GET: api/<ContasController>
        [HttpGet]
        public IEnumerable<ContaBancariacs> Get()
        {
            return rep.ListarContas();
        }

        // GET api/<ContasController>/5
        [HttpGet("{id}")]
        public IActionResult PesquisarContaPorNumero(int id)
        {
            try
            {
                var pesquisa = rep.PesquisarContasID(id);
                if (pesquisa != null)
                {
                    return Ok(pesquisa);
                }
                else
                {
                    return NotFound("Conta não encontrada!");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/<ContasController>
        [HttpPost]
        public IActionResult Post([FromBody] ContaBancariacs conta)
        {
            try
            {
                rep.CriarConta(conta);
                return Ok("Conta criada com sucesso!");

            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException e)
            {
                return BadRequest(e.Message);
            }
            
        }

        // PUT api/<ContasController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ContaBancariacs conta)
        {
            try
            {
                conta.NumeroConta = id;
                if (rep.EditarConta(conta))
                {
                    return Ok("Conta atualizada com sucesso!");
                }
                else
                {
                    return NotFound("Conta não encontrada!");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/<ContasController>/5
        [HttpDelete("{numero}")]
        public IActionResult DeletarConta(int numero)
        {
            try
            {
                var existe = rep.PesquisarContasID(numero);
                if (existe != null)
                {
                    rep.DeletarConta(numero);
                    return Ok("Conta deletada com sucesso!");
                }
                else
                {
                    return NotFound("Conta não encontrada!");   
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
