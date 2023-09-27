using MongoDB.Driver;
using VendasAPI.Entidades;

namespace VendasAPI.Data
{
    public class ContextoVenda : IContextoVenda
    {
        public ContextoVenda(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));

            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Vendas = database.GetCollection<Venda>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));

            ContextoVendaSeed.SeedData(Vendas);
        }
        public IMongoCollection<Venda> Vendas { get; }
    }
}
