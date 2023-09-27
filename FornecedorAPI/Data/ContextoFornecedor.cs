using FornecedorAPI.Entidades;
using MongoDB.Driver;

namespace FornecedorAPI.Data
{
    public class ContextoFornecedor : IContextoFornecedor
    {
        public ContextoFornecedor(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));

            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Fornecedores = database.GetCollection<Fornecedor>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));

            ContextoFornecedorSeed.SeedData(Fornecedores);
        }
        public IMongoCollection<Fornecedor> Fornecedores { get; }
    }
}
