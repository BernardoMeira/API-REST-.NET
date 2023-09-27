using MongoDB.Driver;
using VendasAPI.Entidades;

namespace VendasAPI.Data
{
    public class ContextoVendaSeed
    {
        public static void SeedData(IMongoCollection<Venda> vendaCollection)
        {
            bool existVenda = vendaCollection.Find(v => true).Any();
            if (!existVenda)
            {
                vendaCollection.InsertManyAsync(GetMyVendas());
            }
        }
        private static IEnumerable<Venda> GetMyVendas()
        {
            return new List<Venda>()
            {
            };
        }
    }
}
