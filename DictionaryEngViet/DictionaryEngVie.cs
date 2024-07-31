using Azure;
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
            
            var response = await ApiHelper.FindByName(keyword);

            dataGridView1.DataSource = response;
            

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
