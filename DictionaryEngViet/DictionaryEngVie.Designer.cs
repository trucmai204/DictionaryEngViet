namespace DictionaryEngViet
{
    partial class DictionaryEngVie
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SearchBox = new TextBox();
            SearchBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Word = new DataGridViewTextBoxColumn();
            WordTypeId = new DataGridViewTextBoxColumn();
            Pronounciation = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchBox.BackColor = SystemColors.InactiveCaption;
            SearchBox.Location = new Point(26, 36);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(403, 27);
            SearchBox.TabIndex = 0;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchBtn.BackColor = Color.SteelBlue;
            SearchBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = SystemColors.Desktop;
            SearchBtn.Location = new Point(470, 35);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(87, 29);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Tìm";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(591, 156);
            button1.Name = "button1";
            button1.Size = new Size(126, 29);
            button1.TabIndex = 3;
            button1.Text = "Thêm từ mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(593, 207);
            button2.Name = "button2";
            button2.Size = new Size(124, 29);
            button2.TabIndex = 4;
            button2.Text = "Sửa đổi từ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Word, WordTypeId, Pronounciation, Description });
            dataGridView1.Location = new Point(26, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(531, 321);
            dataGridView1.TabIndex = 5;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 51;
            // 
            // Word
            // 
            Word.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Word.DataPropertyName = "Word";
            Word.HeaderText = "Word";
            Word.MinimumWidth = 6;
            Word.Name = "Word";
            Word.Width = 74;
            // 
            // WordTypeId
            // 
            WordTypeId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            WordTypeId.DataPropertyName = "WordTypeId";
            WordTypeId.HeaderText = "WordTypeId";
            WordTypeId.MinimumWidth = 6;
            WordTypeId.Name = "WordTypeId";
            WordTypeId.Width = 118;
            // 
            // Pronounciation
            // 
            Pronounciation.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Pronounciation.DataPropertyName = "Pronounciation";
            Pronounciation.HeaderText = "Pronounciation";
            Pronounciation.MinimumWidth = 6;
            Pronounciation.Name = "Pronounciation";
            Pronounciation.Width = 138;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 114;
            // 
            // DictionaryEngVie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(758, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBox);
            Name = "DictionaryEngVie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dictionary";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBox;
        private Button SearchBtn;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Word;
        private DataGridViewTextBoxColumn WordTypeId;
        private DataGridViewTextBoxColumn Pronounciation;
        private DataGridViewTextBoxColumn Description;
    }
}
