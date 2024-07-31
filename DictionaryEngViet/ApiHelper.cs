using Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
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
        public static async Task<List<Root>> GetWord(string name)
        {
            _httpClient.BaseAddress = new Uri(_endpoint);

            try
            {
                // Thực hiện yêu cầu GET
                HttpResponseMessage response = await _httpClient.GetAsync($"/api/Volcabularies/GetWord?word={name}");

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
        public static async Task<Root> CreateNewWord(Root vocabulary)
        {
            _httpClient.BaseAddress = new Uri(_endpoint);


            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await _httpClient.PostAsJsonAsync("/api/Vocabularies/Create", vocabulary);
                    response.EnsureSuccessStatusCode();

                    string content = await response.Content.ReadAsStringAsync();
                    List<Root> result = JsonSerializer.Deserialize<List<Root>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi gọi API: {ex.Message}");
                    return null;
                }
            }
        }
    }
}
