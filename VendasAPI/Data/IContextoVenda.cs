using MongoDB.Driver;
using VendasAPI.Entidades;

namespace VendasAPI.Data
{
    public interface IContextoVenda
    {
        IMongoCollection<Venda> Vendas { get; }
    }
}
