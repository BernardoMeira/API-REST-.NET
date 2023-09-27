using FornecedorAPI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Cliente.Servicos
{
    internal class FornecedorAPIServicos
    {
        private static readonly string _urlBase = "http://localhost:8001/";
        public static async Task<List<Fornecedor>> GETFornecedores()
        {
            using (var httpClient = new HttpClient()){

                var client = new FornecedorServicos(_urlBase, httpClient);
                var response = await client.ControladorFornecedorAllAsync().ConfigureAwait(false);

                return response.ToList();
            }
        }

        public static async Task<Fornecedor> GETFornecedor(string id)
        {
            using (var httpClient = new HttpClient())
            {

                var client = new FornecedorServicos(_urlBase, httpClient);
                var response = await client.GetFornecedoresAsync(id);

                return response;
            }
        }

        public static async Task POSTFornecedor(Fornecedor fornecedor)
        {
            using (var httpClient = new HttpClient())
            {
                var client = new FornecedorServicos(_urlBase, httpClient);
                var Tempfornecedor = new Fornecedor();
                Tempfornecedor = fornecedor;

                try
                {
                    await client.ControladorFornecedorPOSTAsync(Tempfornecedor);
                }
                catch (ApiException apiEx)
                {
                    Console.Write(apiEx.ToString());
                }
            }
        }

        public static async Task PUTFornecedor(Fornecedor fornecedor)
        {
            using (var httpClient = new HttpClient())
            {
                var client = new FornecedorServicos(_urlBase, httpClient);
                var Tempfornecedor = new Fornecedor();
                Tempfornecedor = fornecedor;

                try
                {
                    await client.ControladorFornecedorPUTAsync(Tempfornecedor);
                }
                catch (ApiException apiEx)
                {
                    Console.Write(apiEx.ToString());
                }
            }
        }

        public static async Task DELETEFornecedor(string id)
        {
            using (var httpClient = new HttpClient())
            {
                var client = new FornecedorServicos(_urlBase, httpClient);
                try
                {
                    await client.DeleteFornecedorAsync(id);
                }
                catch (ApiException apiEx)
                {
                    Console.Write(apiEx.ToString());
                }
            }
        }
    }
}