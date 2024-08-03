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

            Root newVocabulary = new Root
            {

                Word = comboBox1.Text,
                WordTypeId = (AddWordTypeCb.SelectedIndex + 1),
                Pronounciation = AddPronouTxt.Text,
                Description = DescriptWordRtb.Text
            };
            await ApiHelper.UpdateWord(id, newVocabulary);
        }

        private void UpdateWord_Load(object sender, EventArgs e)
        {

        }
    }
}
