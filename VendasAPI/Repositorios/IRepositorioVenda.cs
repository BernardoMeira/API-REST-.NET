using VendasAPI.Entidades;

namespace VendasAPI.Repositorios
{
    public interface IRepositorioVenda
    {
        // Funções de pesquisa
        Task<IEnumerable<Venda>> GetVendas();
        Task<Venda> GetVenda(string idVenda);

        // Funções de alteração
        Task CreateVenda(Venda venda);
    }
}
