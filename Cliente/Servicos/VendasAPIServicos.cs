using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VendasAPI;

namespace Cliente.Servicos
{
    internal class VendasAPIServicos
    {
        private static readonly string _urlBase = "http://localhost:8002/";
        public static async Task<List<Venda>> GETVendas()
        {
            using (var httpClient = new HttpClient())
            {

                var client = new VendasServicos(_urlBase, httpClient);
                var response = await client.ControladorVendasAllAsync().ConfigureAwait(false);

                return response.ToList();
            }
        }

        public static async Task<Venda> GETVenda(string id)
        {
            using (var httpClient = new HttpClient())
            {

                var client = new VendasServicos(_urlBase, httpClient);
                var response = await client.GetVendaAsync(id);

                return response;
            }
        }

        public static async Task POSTVenda(Venda venda)
        {
            using (var httpClient = new HttpClient())
            {
                var client = new VendasServicos(_urlBase, httpClient);
                var Tempvenda = new Venda();
                Tempvenda = venda;

                try
                {
                    await client.ControladorVendasAsync(venda);
                }
                catch (ApiException apiEx)
                {
                    Console.Write(apiEx.ToString());
                }
            }
        }
    }
}
