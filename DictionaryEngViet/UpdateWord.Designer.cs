namespace DictionaryEngViet
{
    partial class UpdateWord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddWordTypeCb = new ComboBox();
            AddPronouTxt = new TextBox();
            DescriptWordRtb = new RichTextBox();
            AddWordBtn = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // AddWordTypeCb
            // 
            AddWordTypeCb.BackColor = SystemColors.InactiveCaption;
            AddWordTypeCb.FormattingEnabled = true;
            AddWordTypeCb.Items.AddRange(new object[] { "Noun", "Adjective", "Verb", "Adverb" });
            AddWordTypeCb.Location = new Point(381, 102);
            AddWordTypeCb.Name = "AddWordTypeCb";
            AddWordTypeCb.Size = new Size(151, 28);
            AddWordTypeCb.TabIndex = 9;
            // 
            // AddPronouTxt
            // 
            AddPronouTxt.BackColor = SystemColors.InactiveCaption;
            AddPronouTxt.Location = new Point(98, 102);
            AddPronouTxt.Name = "AddPronouTxt";
            AddPronouTxt.Size = new Size(181, 27);
            AddPronouTxt.TabIndex = 8;
            // 
            // DescriptWordRtb
            // 
            DescriptWordRtb.BackColor = SystemColors.InactiveCaption;
            DescriptWordRtb.Location = new Point(98, 167);
            DescriptWordRtb.Name = "DescriptWordRtb";
            DescriptWordRtb.Size = new Size(262, 120);
            DescriptWordRtb.TabIndex = 7;
            DescriptWordRtb.Text = "";
            // 
            // AddWordBtn
            // 
            AddWordBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddWordBtn.BackColor = Color.CornflowerBlue;
            AddWordBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddWordBtn.ForeColor = SystemColors.Desktop;
            AddWordBtn.Location = new Point(395, 254);
            AddWordBtn.Name = "AddWordBtn";
            AddWordBtn.Size = new Size(137, 33);
            AddWordBtn.TabIndex = 5;
            AddWordBtn.Text = "Sửa đổi";
            AddWordBtn.UseVisualStyleBackColor = false;
            AddWordBtn.Click += AddWordBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(434, 28);
            comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 11;
            label1.Text = "Từ vựng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 12;
            label2.Text = "Phiên âm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 105);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 13;
            label3.Text = "Loại từ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 14;
            label4.Text = "Ngữ cảnh";
            // 
            // UpdateWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(558, 314);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(AddWordTypeCb);
            Controls.Add(AddPronouTxt);
            Controls.Add(DescriptWordRtb);
            Controls.Add(AddWordBtn);
            Name = "UpdateWord";
            Text = "UpdateWord";
            Load += UpdateWord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox AddWordTypeCb;
        private TextBox AddPronouTxt;
        private RichTextBox DescriptWordRtb;
        private Button AddWordBtn;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}