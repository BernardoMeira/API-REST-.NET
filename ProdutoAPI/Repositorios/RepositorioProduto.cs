using MongoDB.Driver;
using ProdutoAPI.Data;
using ProdutoAPI.Entidades;

namespace ProdutoAPI.Repositorios
{
    public class RepositorioProduto : IRepositorioProduto
    {
        private readonly IContextoProduto _contexto;
        public RepositorioProduto(IContextoProduto contexto)
        {
            _contexto = contexto;
        }

        //Criação de produto mongoDB
        public async Task CreateProduct(Produto produto)
        {
            await _contexto.Products.InsertOneAsync(produto);
        }

        //Remoção de produto mongoDB
        public async Task<bool> DeleteProduct(string idProduto)
        {
            FilterDefinition<Produto> filter = Builders<Produto>.Filter.Eq(produto => produto.IdProduto, idProduto);

            DeleteResult deleteResult = await _contexto.Products.DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }

        //Pesquisa produto mongoDB
        public async Task<Produto> GetProduct(string idProduto)
        {
            return await _contexto.Products.Find(produto => produto.IdProduto == idProduto).FirstOrDefaultAsync();
        }

        //Filtragem por categoria
        public async Task<IEnumerable<Produto>> GetProductByCategory(string nomeCategoria)
        {
            FilterDefinition<Produto> filter = Builders<Produto>.Filter.Eq(produto => produto.Categoria, nomeCategoria);

            return await _contexto.Products.Find(filter).ToListAsync();
        }

        //Filtragem por nome
        public async Task<IEnumerable<Produto>> GetProductByName(string nome)
        {
            FilterDefinition<Produto> filter = Builders<Produto>.Filter.Eq(produto => produto.Nome, nome);

            return await _contexto.Products.Find(filter).ToListAsync();
        }

        //Obter todos produtos
        public async Task<IEnumerable<Produto>> GetProducts()
        {
            return await _contexto.Products.Find(produto => true).ToListAsync();
        }

        //Atualizar produto
        public async Task<bool> UpdateProduct(Produto produto)
        {
            var updateResult = await _contexto.Products.ReplaceOneAsync(filter: g => g.IdProduto == produto.IdProduto, replacement: produto);

            return updateResult.IsAcknowledged
                && updateResult.ModifiedCount > 0;
        }
    }
}
