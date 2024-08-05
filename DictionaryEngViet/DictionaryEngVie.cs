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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn đầu tiên
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy giá trị của ô đầu tiên
                var cellValue = selectedRow.Cells[0].Value;

                UpdateWord form = new UpdateWord((int)cellValue);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
            
            
        }

        
    }
}
