using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendasAPI.Entidades;
using VendasAPI.Repositorios;

namespace VendasAPI.Controladores
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ControladorVendas : ControllerBase
    {
        private readonly IRepositorioVenda _repositorio;
        public ControladorVendas(IRepositorioVenda repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Venda>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Venda>>> GetVendas()
        {
            var vendas = await _repositorio.GetVendas();
            return Ok(vendas);
        }

        [HttpGet("{id:length(24)}", Name = "GetVenda")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Venda), StatusCodes.Status200OK)]
        public async Task<ActionResult<Venda>> GetVendaById(string id)
        {
            var venda = await _repositorio.GetVenda(id);
            if (venda == null)
            {
                return NotFound();
            }
            return Ok(venda);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Venda), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Venda>> CreateVenda([FromBody] Venda venda)
        {
            if (venda == null)
            {
                return BadRequest("Venda Invalida");
            }
            await _repositorio.CreateVenda(venda);

            return CreatedAtRoute("GetVenda", new { idVenda = venda.IdVenda }, venda);
        }
    }
}
