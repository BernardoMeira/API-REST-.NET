using MongoDB.Driver;
using VendasAPI.Data;
using VendasAPI.Entidades;

namespace VendasAPI.Repositorios
{
    public class RepositorioVenda : IRepositorioVenda
    {
        private readonly IContextoVenda _contexto;
        public RepositorioVenda(IContextoVenda contexto)
        {
            _contexto = contexto;
        }

        //Criação de venda mongoDB
        public async Task CreateVenda(Venda venda)
        {
            await _contexto.Vendas.InsertOneAsync(venda);
        }

        //Pesquisa venda mongoDB
        public async Task<Venda> GetVenda(string idVenda)
        {
            return await _contexto.Vendas.Find(venda => venda.IdVenda == idVenda).FirstOrDefaultAsync();
        }

        //Obter todas vendas
        public async Task<IEnumerable<Venda>> GetVendas()
        {
            return await _contexto.Vendas.Find(venda => true).ToListAsync();
        }
    }
}
