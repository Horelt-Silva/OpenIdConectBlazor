using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text;

namespace IdentityServerGoogleAuthentication.Client.Repositories
{
    public class Repositorie : IRepositories
    {
        private JsonSerializerOptions jsonOptions => new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        private HttpClient httpClient = new HttpClient();

        public Task<HttpResponseWrapper<object>> Delete(string url)
        {
            throw new System.NotImplementedException();
        }

        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {

            var responseHttp = await httpClient.GetAsync(url);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializeResponse<T>(responseHttp, jsonOptions);
                return new HttpResponseWrapper<T>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHttp);
            }
        }

        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializeResponse<TResponse>(responseHttp, jsonOptions);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default, true, responseHttp);
            }
        }

        public Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar)
        {
            throw new System.NotImplementedException();
        }

        private async Task<T> DeserializeResponse<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }

    }
}