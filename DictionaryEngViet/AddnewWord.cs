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
            Vocabulary newVocabulary = new Vocabulary
            {
                Word = AddwordTxt.Text,
                WordTypeId = (EnumWordType)AddWordTypeCb.SelectedIndex,
                Pronounciation = AddPronouTxt.Text,
                Description = DescriptWordRtb.Text
            };

            bool response = await CreateVocabulary(newVocabulary);
            if (response)
            {
                Console.WriteLine("Từ vựng đã được tạo thành công.");
            }
            else
            {
                Console.WriteLine("Đã có lỗi xảy ra khi tạo từ vựng.");
            }
            this.Close();
        }


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
                        Console.WriteLine($"Lỗi khi gọi API: {response.StatusCode}");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi gọi API: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
