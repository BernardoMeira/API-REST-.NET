using MongoDB.Driver;
using ProdutoAPI.Entidades;

namespace ProdutoAPI.Data
{
    public interface IContextoProduto
    {
        IMongoCollection<Produto> Products { get; }
    }
}
