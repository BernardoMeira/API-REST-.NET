using FornecedorAPI.Entidades;

namespace FornecedorAPI.Repositorios
{
    public interface IRepositorioFornecedor
    {
        // Funções de pesquisa
        Task<IEnumerable<Fornecedor>> GetFornecedores();
        Task<Fornecedor> GetFornecedor(string idFornecedor);
        Task<IEnumerable<Fornecedor>> GetFornecedorByName(string nome);

        // Funções de alteração
        Task CreateFornecedor(Fornecedor fornecedor);
        Task<bool> UpdateFornecedor(Fornecedor fornecedor);
        Task<bool> DeleteFornecedor(string idFornecedor);
    }
}
