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
            AddwordTxt = new TextBox();
            AddWordBtn = new Button();
            SuspendLayout();
            // 
            // AddWordTypeCb
            // 
            AddWordTypeCb.BackColor = SystemColors.InactiveCaption;
            AddWordTypeCb.FormattingEnabled = true;
            AddWordTypeCb.Items.AddRange(new object[] { "Noun", "Adjective", "Verb", "Adverb" });
            AddWordTypeCb.Location = new Point(336, 101);
            AddWordTypeCb.Name = "AddWordTypeCb";
            AddWordTypeCb.Size = new Size(151, 28);
            AddWordTypeCb.TabIndex = 9;
            // 
            // AddPronouTxt
            // 
            AddPronouTxt.BackColor = SystemColors.InactiveCaption;
            AddPronouTxt.Location = new Point(71, 102);
            AddPronouTxt.Name = "AddPronouTxt";
            AddPronouTxt.Size = new Size(181, 27);
            AddPronouTxt.TabIndex = 8;
            // 
            // DescriptWordRtb
            // 
            DescriptWordRtb.BackColor = SystemColors.InactiveCaption;
            DescriptWordRtb.Location = new Point(71, 152);
            DescriptWordRtb.Name = "DescriptWordRtb";
            DescriptWordRtb.Size = new Size(262, 120);
            DescriptWordRtb.TabIndex = 7;
            DescriptWordRtb.Text = "";
            // 
            // AddwordTxt
            // 
            AddwordTxt.BackColor = SystemColors.InactiveCaption;
            AddwordTxt.Location = new Point(71, 43);
            AddwordTxt.Name = "AddwordTxt";
            AddwordTxt.Size = new Size(416, 27);
            AddwordTxt.TabIndex = 6;
            // 
            // AddWordBtn
            // 
            AddWordBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddWordBtn.BackColor = Color.CornflowerBlue;
            AddWordBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddWordBtn.ForeColor = SystemColors.Desktop;
            AddWordBtn.Location = new Point(350, 239);
            AddWordBtn.Name = "AddWordBtn";
            AddWordBtn.Size = new Size(137, 33);
            AddWordBtn.TabIndex = 5;
            AddWordBtn.Text = "Sửa đổi";
            AddWordBtn.UseVisualStyleBackColor = false;
            AddWordBtn.Click += AddWordBtn_Click;
            // 
            // UpdateWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(558, 314);
            Controls.Add(AddWordTypeCb);
            Controls.Add(AddPronouTxt);
            Controls.Add(DescriptWordRtb);
            Controls.Add(AddwordTxt);
            Controls.Add(AddWordBtn);
            Name = "UpdateWord";
            Text = "UpdateWord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox AddWordTypeCb;
        private TextBox AddPronouTxt;
        private RichTextBox DescriptWordRtb;
        private TextBox AddwordTxt;
        private Button AddWordBtn;
    }
}