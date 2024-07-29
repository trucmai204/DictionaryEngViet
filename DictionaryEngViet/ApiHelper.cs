using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEngViet
{
    public class Root
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("wordTypeId")]
        public int? WordTypeId { get; set; }

        [JsonProperty("pronounciation")]
        public string Pronounciation { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
    public static class ApiHelper
    {
        private static readonly string _endpoint = "https://localhost:7271";
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task<List<Root>> FindByName(string name)
        {
            _httpClient.BaseAddress = new Uri(_endpoint);

            try
            {
                // Thực hiện yêu cầu GET
                HttpResponseMessage response = await _httpClient.GetAsync($"/api/Volcabularies/FindByWord?keyword={name}");

                response.EnsureSuccessStatusCode();
                string content = await response.Content.ReadAsStringAsync();
                List<Root> result = JsonConvert.DeserializeObject<List<Root>>(content);
                return result;
            }
            catch
            {
                throw;
            }
        }
           
    }
}
