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
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchBox.Location = new Point(110, 20);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(445, 27);
            SearchBox.TabIndex = 0;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchBtn.Location = new Point(561, 18);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(87, 29);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Tìm";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // DisplayContent
            // 
            DisplayContent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayContent.Location = new Point(59, 93);
            DisplayContent.Name = "DisplayContent";
            DisplayContent.Size = new Size(640, 315);
            DisplayContent.TabIndex = 2;
            DisplayContent.Text = "";
            // 
            // DictionaryEngVie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 450);
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
    }
}
