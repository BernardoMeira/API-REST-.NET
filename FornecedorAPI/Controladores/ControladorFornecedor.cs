using FornecedorAPI.Entidades;
using FornecedorAPI.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FornecedorAPI.Controladores
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ControladorFornecedor : ControllerBase
    {
        private readonly IRepositorioFornecedor _repositorio;
        public ControladorFornecedor(IRepositorioFornecedor repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Fornecedor>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Fornecedor>>> GetFornecedores()
        {
            var fornecedores = await _repositorio.GetFornecedores();
            return Ok(fornecedores);
        }

        [HttpGet("{id:length(24)}", Name = "GetFornecedores")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Fornecedor), StatusCodes.Status200OK)]
        public async Task<ActionResult<Fornecedor>> GetFornecedoresById(string id)
        {
            var fornecedor = await _repositorio.GetFornecedor(id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return Ok(fornecedor);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Fornecedor), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Fornecedor>> CreateFornecedor([FromBody] Fornecedor fornecedor)
        {
            if (fornecedor == null)
            {
                return BadRequest("Fornecedor Invalido");
            }
            await _repositorio.CreateFornecedor(fornecedor);

            return CreatedAtRoute("GetFornecedor", new { id = fornecedor.IdFornecedor }, fornecedor);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Fornecedor), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateFornecedor([FromBody] Fornecedor fornecedor)
        {
            if (fornecedor == null)
            {
                return BadRequest("Fornecedor Invalido");
            }

            return Ok(await _repositorio.UpdateFornecedor(fornecedor));
        }

        [HttpDelete("{id:length(24)}", Name = "DeleteFornecedor")]
        [ProducesResponseType(typeof(Fornecedor), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteFornecedorById(string id)
        {
            return Ok(await _repositorio.DeleteFornecedor(id));
        }
    }
}
