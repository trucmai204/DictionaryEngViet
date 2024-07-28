﻿using Azure;
using Entities;
using Newtonsoft.Json;
using System.Net.Http.Json;


namespace DictionaryEngViet
{
    public partial class DictionaryEngVie : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public DictionaryEngVie()
        {
            InitializeComponent();
        }
       

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            string keyword = SearchBox.Text;
            var response = await GetVocabularyByKeyword(keyword);

            var vocabularies = JsonConvert.DeserializeObject<List<Vocabulary>>(response);

            //foreach (var vocabulary in vocabularies)
            //{
            //    dataGridView1.Text += $"{vocabulary.Word} \n {vocabulary.WordTypeId} \n {vocabulary.Pronounciation} \n {vocabulary.Description} \n";
            //}
            dataGridView1.DataSource = vocabularies;
            //DisplayContent.Text = $" {vocabularies.FirstOrDefault().Word } \n {vocabularies.FirstOrDefault().WordTypeId} " +
            //    $"\n {vocabularies.FirstOrDefault().Pronounciation} \n {vocabularies.FirstOrDefault().Description}";


        }
        async Task<string> GetVocabularyByKeyword(string keyword)
        {
            string url = $"https://localhost:7271/api/Volcabularies/FindByWord?keyword={keyword}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/plain"));

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return $"Error: {response.StatusCode}";
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            AddnewWord form = new AddnewWord();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
                UpdateWord form = new UpdateWord(1);
                form.ShowDialog();
            
        }

        
    }
}
