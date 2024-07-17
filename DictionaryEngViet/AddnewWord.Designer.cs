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
            SuspendLayout();
            // 
            // AddWordBtn
            // 
            AddWordBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddWordBtn.BackColor = Color.CornflowerBlue;
            AddWordBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddWordBtn.ForeColor = SystemColors.Desktop;
            AddWordBtn.Location = new Point(359, 234);
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
            AddwordTxt.Location = new Point(80, 38);
            AddwordTxt.Name = "AddwordTxt";
            AddwordTxt.Size = new Size(416, 27);
            AddwordTxt.TabIndex = 1;
            // 
            // DescriptWordRtb
            // 
            DescriptWordRtb.BackColor = SystemColors.InactiveCaption;
            DescriptWordRtb.Location = new Point(80, 147);
            DescriptWordRtb.Name = "DescriptWordRtb";
            DescriptWordRtb.Size = new Size(262, 120);
            DescriptWordRtb.TabIndex = 2;
            DescriptWordRtb.Text = "";
            // 
            // AddPronouTxt
            // 
            AddPronouTxt.BackColor = SystemColors.InactiveCaption;
            AddPronouTxt.Location = new Point(80, 97);
            AddPronouTxt.Name = "AddPronouTxt";
            AddPronouTxt.Size = new Size(181, 27);
            AddPronouTxt.TabIndex = 3;
            // 
            // AddWordTypeCb
            // 
            AddWordTypeCb.BackColor = SystemColors.InactiveCaption;
            AddWordTypeCb.FormattingEnabled = true;
            AddWordTypeCb.Location = new Point(345, 96);
            AddWordTypeCb.Name = "AddWordTypeCb";
            AddWordTypeCb.Size = new Size(151, 28);
            AddWordTypeCb.TabIndex = 4;
            // 
            // AddnewWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(577, 303);
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
    }
}