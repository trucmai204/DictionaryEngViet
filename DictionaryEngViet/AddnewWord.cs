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
            
            Root newVocabulary = new Root
            {
                Word = AddwordTxt.Text,
                WordTypeId = (AddWordTypeCb.SelectedIndex + 1),
                Pronounciation = AddPronouTxt.Text,
                Description = DescriptWordRtb.Text
            };

            await ApiHelper.CreateNewWord(newVocabulary);
            
            this.Close();
        }

     
        private void AddnewWord_Load(object sender, EventArgs e)
        {

        }
    }
}
