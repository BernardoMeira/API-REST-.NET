using FornecedorAPI.Data;
using FornecedorAPI.Entidades;
using MongoDB.Driver;

namespace FornecedorAPI.Repositorios
{
    public class RepositorioFornecedor : IRepositorioFornecedor
    {
        private readonly IContextoFornecedor _contexto;
        public RepositorioFornecedor(IContextoFornecedor contexto)
        {
            _contexto = contexto;
        }

        //Criação de Fornecedor mongoDB
        public async Task CreateFornecedor(Fornecedor fornecedor)
        {
            await _contexto.Fornecedores.InsertOneAsync(fornecedor);
        }

        //Remoção de Fornecedor mongoDB
        public async Task<bool> DeleteFornecedor(string idFornecedor)
        {
            FilterDefinition<Fornecedor> filter = Builders<Fornecedor>.Filter.Eq(fornecedor => fornecedor.IdFornecedor, idFornecedor);

            DeleteResult deleteResult = await _contexto.Fornecedores.DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }

        //Pesquisa Fornecedor mongoDB
        public async Task<Fornecedor> GetFornecedor(string idFornecedor)
        {
            return await _contexto.Fornecedores.Find(fornecedor => fornecedor.IdFornecedor == idFornecedor).FirstOrDefaultAsync();
        }

        //Filtragem por nome
        public async Task<IEnumerable<Fornecedor>> GetFornecedorByName(string nome)
        {
            FilterDefinition<Fornecedor> filter = Builders<Fornecedor>.Filter.Eq(fornecedor => fornecedor.Nome, nome);

            return await _contexto.Fornecedores.Find(filter).ToListAsync();
        }

        //Obter todos Fornecedores
        public async Task<IEnumerable<Fornecedor>> GetFornecedores()
        {
            return await _contexto.Fornecedores.Find(Fornecedor => true).ToListAsync();
        }

        //Atualizar Fornecedor
        public async Task<bool> UpdateFornecedor(Fornecedor fornecedor)
        {
            var updateResult = await _contexto.Fornecedores.ReplaceOneAsync(filter: g => g.IdFornecedor == fornecedor.IdFornecedor, replacement: fornecedor);

            return updateResult.IsAcknowledged
                && updateResult.ModifiedCount > 0;
        }
    }
}
