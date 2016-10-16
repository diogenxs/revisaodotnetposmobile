using Newtonsoft.Json;
using Revisao.Net.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Net.Client.Logic
{
    public class TarefasRequestApi
    {
        public static async Task<List<Tarefa>> ListarTarefas(string token)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(App.BaseUrl)
            };

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var response = await client.GetAsync("api/Tarefa");

            try
            {
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                var lista = JsonConvert.DeserializeObject<List<Tarefa>>(json);

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal static async Task GravarTarefa(Tarefa tarefa)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(App.BaseUrl)
            };

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + MyLocalStorage.GetFromLocalStorage("token"));

            var json = JsonConvert.SerializeObject(tarefa);

            var dados = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("/api/Tarefa", dados);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception)
            {

                throw;
            }

        }

        internal async static Task AlterarTarefa(Tarefa tarefa)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(App.BaseUrl)
            };

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + MyLocalStorage.GetFromLocalStorage("token"));

            var json = JsonConvert.SerializeObject(tarefa);

            var dados = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync("/api/Tarefa/" + tarefa.Id , dados);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
