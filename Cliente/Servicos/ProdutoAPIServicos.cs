using ProdutoAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Servicos
{
    internal class ProdutoAPIServicos
    {
        private static readonly string _urlBase = "http://localhost:8000/";
        public static async Task<List<Produto>> GETProdutos()
        {
            using (var httpClient = new HttpClient())
            {

                var client = new ProdutoServicos(_urlBase, httpClient);
                var response = await client.ControladorProdutoAllAsync().ConfigureAwait(false);

                return response.ToList();
            }
        }

        public static async Task<Produto> GETProduto(string id)
        {
            using (var httpClient = new HttpClient())
            {

                var client = new ProdutoServicos(_urlBase, httpClient);
                var response = await client.GetProductAsync(id);

                return response;
            }
        }
        /*
        public static async Task<Produto> GETProdutoNome(string nome)
        {
            using (var httpClient = new HttpClient())
            {

                var client = new ProdutoServicos(_urlBase, httpClient);
                var response = await client.GetProductByName(nome);

                return response;
            }
        }
        */
        public static async Task POSTProduto(Produto produto)
        {
            using (var httpClient = new HttpClient())
            {
                var client = new ProdutoServicos(_urlBase, httpClient);
                var Tempproduto = new Produto();
                Tempproduto = produto;

                try
                {
                    await client.ControladorProdutoPOSTAsync(Tempproduto);
                }
                catch (ApiException apiEx)
                {
                    Console.Write(apiEx.ToString());
                }
            }
        }

        public static async Task PUTProduto(Produto produto)
        {
            using (var httpClient = new HttpClient())
            {
                var client = new ProdutoServicos(_urlBase, httpClient);
                var Tempproduto = new Produto();
                Tempproduto = produto;

                try
                {
                    await client.ControladorProdutoPUTAsync(Tempproduto);
                }
                catch (ApiException apiEx)
                {
                    Console.Write(apiEx.ToString());
                }
            }
        }

        public static async Task DELETEProduto(string id)
        {
            using (var httpClient = new HttpClient())
            {
                var client = new ProdutoServicos(_urlBase, httpClient);
                try
                {
                    await client.DeleteProductAsync(id);
                }
                catch (ApiException apiEx)
                {
                    Console.Write(apiEx.ToString());
                }
            }
        }
    }
}
