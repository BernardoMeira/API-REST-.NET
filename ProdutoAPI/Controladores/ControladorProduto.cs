using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdutoAPI.Entidades;
using ProdutoAPI.Repositorios;

namespace ProdutoAPI.Controladores
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ControladorProduto : ControllerBase
    {
        private readonly IRepositorioProduto _repositorio;
        public ControladorProduto(IRepositorioProduto repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Produto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProducts()
        {
            var products = await _repositorio.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id:length(24)}", Name = "GetProduct")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
        public async Task<ActionResult<Produto>> GetProductsById(string id)
        {
            var product = await _repositorio.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [Route("[action]/{category}", Name = "GetProductByCategory")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Produto>))]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProductByCategory(string category)
        {
            if (category == null)
            {
                return BadRequest("Invalid Category");
            }
            var products = await _repositorio.GetProductByCategory(category);

            return Ok(products);
        }

        [Route("[action]/{nome}", Name = "GetProductByName")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Produto>))]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProductByName(string nome)
        {
            if (nome == null)
            {
                return BadRequest("Invalid Name");
            }
            var products = await _repositorio.GetProductByName(nome);

            return Ok(products);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Produto>> CreateProduct([FromBody] Produto produto)
        {
            if (produto == null)
            {
                return BadRequest("Invalid Product");
            }
            await _repositorio.CreateProduct(produto);

            return CreatedAtRoute("GetProduct", new { id = produto.IdProduto }, produto);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProduct([FromBody] Produto product)
        {
            if (product == null)
            {
                return BadRequest("Invalid product");
            }

            return Ok(await _repositorio.UpdateProduct(product));
        }

        [HttpDelete("{id:length(24)}", Name = "DeleteProduct")]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteProductById(string id)
        {
            return Ok(await _repositorio.DeleteProduct(id));
        }
    }
}
