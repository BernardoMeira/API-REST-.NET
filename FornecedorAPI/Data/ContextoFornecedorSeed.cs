using FornecedorAPI.Entidades;
using MongoDB.Driver;

namespace FornecedorAPI.Data
{
    public class ContextoFornecedorSeed
    {
        public static void SeedData(IMongoCollection<Fornecedor> fornecedorCollection)
        {
            bool existFornecedor = fornecedorCollection.Find(f => true).Any();
            if (!existFornecedor)
            {
                fornecedorCollection.InsertManyAsync(GetMyFornecedores());
            }
        }

        private static IEnumerable<Fornecedor> GetMyFornecedores()
        {
            return new List<Fornecedor>()
            {
            };
        }
    }
}