namespace DictionaryEngViet
{
    partial class Form1
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
            ResultBox = new RichTextBox();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SearchBox.Location = new Point(220, 36);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(313, 27);
            SearchBox.TabIndex = 0;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Right;
            SearchBtn.Location = new Point(535, 36);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(87, 29);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Tìm";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // ResultBox
            // 
            ResultBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ResultBox.Location = new Point(110, 98);
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.Size = new Size(633, 301);
            ResultBox.TabIndex = 2;
            ResultBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 450);
            Controls.Add(ResultBox);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dictionary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBox;
        private Button SearchBtn;
        private RichTextBox ResultBox;
    }
}
