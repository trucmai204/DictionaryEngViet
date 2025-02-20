﻿using Entities;
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
        private static HttpClient _httpClient = new HttpClient();

        public static async Task<List<Root>> FindByName(string name)
        {
            
            try
            {
                // Thực hiện yêu cầu GET
                HttpResponseMessage response = await _httpClient.GetAsync($"{_endpoint}/api/Vocabularies/FindByWord?keyword={name}");

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
        public static async Task<Root> FindById(int id)
        {
           try
            {
                // Thực hiện yêu cầu GET
                HttpResponseMessage response = await _httpClient.GetAsync($"{_endpoint}/api/Vocabularies/FindById?id={id}");
               
                response.EnsureSuccessStatusCode();
                string content = await response.Content.ReadAsStringAsync();
                Root result = JsonConvert.DeserializeObject<Root>(content);
                return result;
            }
            catch
            {
                throw;
            }
        }
        //public static async Task GetWord(string word)
        //{
        //    try
        //    {
        //        HttpResponseMessage message = await _httpClient.GetAsync($"{_endpoint}/api/Vocabularies/GetWord?name={word}");
        //        message.EnsureSuccessStatusCode();
           
        //    }
        //    catch 
        //    {
        //        throw;
        //    }
        //}
        public static async Task CreateNewWord(Root vocabulary)
        {
            var requestBody = JsonConvert.SerializeObject(vocabulary);
            var content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            try
            {
                var response = await _httpClient.PostAsync($"{_endpoint}/api/Vocabularies/Create", content);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gọi API: {ex.Message}");

            }
        }
        public static async Task UpdateWord(int id, Root vocabulary)
        {
               
            try
            {
                var response = await _httpClient.PostAsJsonAsync($"{_endpoint}/api/Vocabularies/Update?id={id}", vocabulary);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gọi API: {ex.Message}");

            }
        }

    }
}
