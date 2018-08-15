using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EnvironmentDotNet.Core.Networking
{
    public class NetworkService : INetworkService
    {
        public NetworkService()
        {
            
        }
        
        public async Task<T> GetJson<T>(string uri)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    using (HttpResponseMessage response = await client.GetAsync(
                        $"{uri}"))
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<T>(responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Error occurred in GET request.");
                throw;
            }
        }

        public async Task<TOut> PostJson<TIn, TOut>(string uri, TIn content)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    var serialized = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");

                    using (HttpResponseMessage response = await client.PostAsync(
                        $"{uri}", serialized))
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<TOut>(responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Error occurred in POST request.");
                throw;
            }
        }
    }
}