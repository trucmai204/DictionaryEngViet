using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryEngViet
{
    public partial class AddnewWord : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public AddnewWord()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //    EnumWordType wordType = EnumWordType.Verb; // Thay đổi giá trị wordType tùy theo nhu cầu

            //    Vocabulary vocabulary = await GetVocabularyByWordType(wordType);
            //    vocabulary.WordTypeId = (EnumWordType)AddWordTypeCb.SelectedIndex;

            Vocabulary newVocabulary = new Vocabulary
            {
                Word = AddwordTxt.Text,
                WordTypeId = (EnumWordType)(AddWordTypeCb.SelectedIndex + 1),
                Pronounciation = AddPronouTxt.Text,
                Description = DescriptWordRtb.Text
            };

            bool response1 = await CreateVocabulary(newVocabulary);
            if (response1)
            {
                MessageBox.Show("Từ vựng đã được tạo thành công.");
            }
            //else
            //{
            //    MessageBox.Show("Đã có lỗi xảy ra khi tạo từ vựng.");
            //}
            this.Close();
        }

        //async Task<Vocabulary> GetVocabularyByWordType(EnumWordType wordType)
        //{
        //    string apiUrl = $"https://localhost:7271/api/Volcabularies/GetWordTypeOf?wordType={(int)wordType}";

        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage response = await client.GetAsync(apiUrl);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            string jsonContent = await response.Content.ReadAsStringAsync();
        //            return JsonConvert.DeserializeObject<Vocabulary>(jsonContent);
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Lỗi khi gọi API: {response.StatusCode}");
        //            return null;
        //        }
        //    }
        //}
        async Task<bool> CreateVocabulary(Vocabulary newVocabulary)
        {
            string url = "https://localhost:7271/api/Volcabularies/Create";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync(url, newVocabulary);

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi khi gọi API: {response.StatusCode}");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi gọi API: {ex.Message}");
                    return false;
                }
            }
        }

        private void AddnewWord_Load(object sender, EventArgs e)
        {

        }
    }
}
