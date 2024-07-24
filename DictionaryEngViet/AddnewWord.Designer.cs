namespace DictionaryEngViet
{
    partial class AddnewWord
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
            AddWordBtn = new Button();
            AddwordTxt = new TextBox();
            DescriptWordRtb = new RichTextBox();
            AddPronouTxt = new TextBox();
            AddWordTypeCb = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // AddWordBtn
            // 
            AddWordBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddWordBtn.BackColor = Color.CornflowerBlue;
            AddWordBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddWordBtn.ForeColor = SystemColors.Desktop;
            AddWordBtn.Location = new Point(448, 299);
            AddWordBtn.Name = "AddWordBtn";
            AddWordBtn.Size = new Size(137, 33);
            AddWordBtn.TabIndex = 0;
            AddWordBtn.Text = "Thêm từ mới";
            AddWordBtn.UseVisualStyleBackColor = false;
            AddWordBtn.Click += button1_Click;
            // 
            // AddwordTxt
            // 
            AddwordTxt.BackColor = SystemColors.InactiveCaption;
            AddwordTxt.Location = new Point(139, 38);
            AddwordTxt.Name = "AddwordTxt";
            AddwordTxt.Size = new Size(446, 27);
            AddwordTxt.TabIndex = 1;
            // 
            // DescriptWordRtb
            // 
            DescriptWordRtb.BackColor = SystemColors.InactiveCaption;
            DescriptWordRtb.Location = new Point(139, 147);
            DescriptWordRtb.Name = "DescriptWordRtb";
            DescriptWordRtb.Size = new Size(446, 120);
            DescriptWordRtb.TabIndex = 2;
            DescriptWordRtb.Text = "";
            // 
            // AddPronouTxt
            // 
            AddPronouTxt.BackColor = SystemColors.InactiveCaption;
            AddPronouTxt.Location = new Point(139, 96);
            AddPronouTxt.Name = "AddPronouTxt";
            AddPronouTxt.Size = new Size(181, 27);
            AddPronouTxt.TabIndex = 3;
            // 
            // AddWordTypeCb
            // 
            AddWordTypeCb.BackColor = SystemColors.InactiveCaption;
            AddWordTypeCb.FormattingEnabled = true;
            AddWordTypeCb.Items.AddRange(new object[] { "Noun", "Adjective", "Verb", "Adverb" });
            AddWordTypeCb.Location = new Point(434, 96);
            AddWordTypeCb.Name = "AddWordTypeCb";
            AddWordTypeCb.Size = new Size(151, 28);
            AddWordTypeCb.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 41);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 5;
            label1.Text = "Từ vựng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 99);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Phiên âm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 99);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 7;
            label3.Text = "Loại từ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 150);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 8;
            label4.Text = "Ngữ cảnh";
            // 
            // AddnewWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(652, 356);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddWordTypeCb);
            Controls.Add(AddPronouTxt);
            Controls.Add(DescriptWordRtb);
            Controls.Add(AddwordTxt);
            Controls.Add(AddWordBtn);
            Name = "AddnewWord";
            Text = "AddnewWord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddWordBtn;
        private TextBox AddwordTxt;
        private RichTextBox DescriptWordRtb;
        private TextBox AddPronouTxt;
        private ComboBox AddWordTypeCb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}