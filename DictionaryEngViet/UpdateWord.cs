using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryEngViet
{
    public partial class UpdateWord : Form
    {
        private int id;
        public UpdateWord(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private async void AddWordBtn_Click(object sender, EventArgs e)
        {
            
            Vocabulary newVocabulary = new Vocabulary
            {
                
                Word = comboBox1.Text,
                WordTypeId = (EnumWordType)(AddWordTypeCb.SelectedIndex + 1),
                Pronounciation = AddPronouTxt.Text,
                Description = DescriptWordRtb.Text
            };
            bool response = await UpdateVocabulary(newVocabulary);
        }

        private async Task<bool> UpdateVocabulary(Vocabulary newVocabulary)
        {
            string apiUrl = $"https://localhost:7271/api/Volcabularies/Upgrade{id}"; // URL của API

            using (HttpClient client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("*/*"));
                //client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                //// Chuyển đổi đối tượng Vocabulary thành chuỗi JSON
                //string jsonContent = JsonConvert.SerializeObject(vocabulary);
                //StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                //// Gửi yêu cầu POST đến API và lấy phản hồi
                //HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                //// Kiểm tra xem yêu cầu đã thành công hay không
                //return response.IsSuccessStatusCode;
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync(apiUrl, newVocabulary);

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
    }
}
