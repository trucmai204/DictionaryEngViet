using Entities;
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
            string apiUrl = $"https://localhost:7271/api/Volcabularies/FindByWord?keyword=bo{keyword}";
            var vocabularies = await GetVocabulariesAsync(apiUrl);
            // Hiển thị kết quả
            DisplayContent.Clear(); // Giả sử bạn có một RichTextBox tên là DisplayContent
            foreach (var vocab in vocabularies)
            {
                DisplayContent.AppendText($"Word: {vocab.Word}\n");
                DisplayContent.AppendText($"Type ID: {vocab.WordTypeId}\n");
                DisplayContent.AppendText($"Pronounciation: {vocab.Pronounciation}\n");
                DisplayContent.AppendText($"Description: {vocab.Description}\n");
                DisplayContent.AppendText("\n");
            }
        }
        private async Task<List<Vocabulary>> GetVocabulariesAsync(string apiUrl)
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Vocabulary>>();
        }
    }
}
