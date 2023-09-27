using FornecedorAPI.Entidades;
using MongoDB.Driver;

namespace FornecedorAPI.Data
{
    public interface IContextoFornecedor
    {
        IMongoCollection<Fornecedor> Fornecedores { get; }
    }
}
