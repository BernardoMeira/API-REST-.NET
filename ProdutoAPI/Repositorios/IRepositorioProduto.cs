using ProdutoAPI.Entidades;

namespace ProdutoAPI.Repositorios
{
    public interface IRepositorioProduto
    {
        // Funções de pesquisa
        Task<IEnumerable<Produto>> GetProducts();
        Task<Produto> GetProduct(string idProduto);
        Task<IEnumerable<Produto>> GetProductByName(string nome);
        Task<IEnumerable<Produto>> GetProductByCategory(string nomeCategoria);

        // Funções de alteração
        Task CreateProduct(Produto produto);
        Task<bool> UpdateProduct(Produto produto);
        Task<bool> DeleteProduct(string idProduto);
    }
}
