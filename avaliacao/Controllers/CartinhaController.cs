using avaliacao.Models;
using avaliacao.Services;
using Microsoft.AspNetCore.Mvc;

namespace avaliacao.Controllers
{
    [ApiController]
    [Route("api/cartinha")]
    public class CartinhaController : ControllerBase
    {
        private readonly ICartinhaRepository _cartinhaRepository;
        public CartinhaController(ICartinhaRepository cartinhaRepository)
        {
            _cartinhaRepository = cartinhaRepository;
        }
        [HttpGet]
        public IActionResult OlaCriança()
        {
            return Ok("Ola Criança");
        }
        [HttpPost]
        [Route("Inserir")]
        public IActionResult Inserir(NovaCartinha dados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _cartinhaRepository.Inserir(new DadosCartinha()
            {
                nome = dados.nome,
                endereço = dados.endereço,
                idade = dados.idade,
                texto = dados.texto,
            });
        }
    }
}
