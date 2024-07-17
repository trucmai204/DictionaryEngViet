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
            DisplayContent = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchBox.BackColor = SystemColors.InactiveCaption;
            SearchBox.Location = new Point(26, 35);
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
            SearchBtn.Location = new Point(445, 34);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(87, 29);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Tìm";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // DisplayContent
            // 
            DisplayContent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayContent.BackColor = Color.LightBlue;
            DisplayContent.Location = new Point(26, 84);
            DisplayContent.Name = "DisplayContent";
            DisplayContent.Size = new Size(506, 354);
            DisplayContent.TabIndex = 2;
            DisplayContent.Text = "";
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
            // DictionaryEngVie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(758, 450);
            Controls.Add(button1);
            Controls.Add(DisplayContent);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBox);
            Name = "DictionaryEngVie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dictionary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBox;
        private Button SearchBtn;
        private RichTextBox DisplayContent;
        private Button button1;
    }
}
