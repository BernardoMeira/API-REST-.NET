using MongoDB.Driver;
using ProdutoAPI.Entidades;
using Microsoft.Extensions.Configuration;

namespace ProdutoAPI.Data
{
    public class ContextoProduto : IContextoProduto
    {
        public ContextoProduto(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));

            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Products = database.GetCollection<Produto>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));

            ContextoProdutoSeed.SeedData(Products);
        }
        public IMongoCollection<Produto> Products { get; }
    }
}
