using MongoDB.Driver;
using ProdutoAPI.Entidades;

namespace ProdutoAPI.Data
{
    public class ContextoProdutoSeed
    {
        public static void SeedData(IMongoCollection<Produto> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Produto> GetMyProducts()
        {
            return new List<Produto>()
            {
            };
        }
    }
}
