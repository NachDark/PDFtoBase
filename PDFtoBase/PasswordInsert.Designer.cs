namespace PDFtoBase
{
    partial class PasswordInsert
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
            GetFileBut = new Button();
            JaviertextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            IsraeltextBox = new TextBox();
            label3 = new Label();
            AdriantextBox = new TextBox();
            SuspendLayout();
            // 
            // GetFileBut
            // 
            GetFileBut.Location = new Point(680, 64);
            GetFileBut.Name = "GetFileBut";
            GetFileBut.Size = new Size(75, 23);
            GetFileBut.TabIndex = 0;
            GetFileBut.Text = "Get File";
            GetFileBut.UseVisualStyleBackColor = true;
            GetFileBut.Click += GetFileBut_Click;
            // 
            // JaviertextBox
            // 
            JaviertextBox.Location = new Point(63, 27);
            JaviertextBox.Name = "JaviertextBox";
            JaviertextBox.Size = new Size(436, 23);
            JaviertextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 2;
            label1.Text = "Contraseña Grupo Javier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 63);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña Grupo Israel";
            // 
            // IsraeltextBox
            // 
            IsraeltextBox.Location = new Point(63, 81);
            IsraeltextBox.Name = "IsraeltextBox";
            IsraeltextBox.Size = new Size(436, 23);
            IsraeltextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 120);
            label3.Name = "label3";
            label3.Size = new Size(141, 15);
            label3.TabIndex = 6;
            label3.Text = "Contraseña Grupo Adrian";
            // 
            // AdriantextBox
            // 
            AdriantextBox.Location = new Point(63, 138);
            AdriantextBox.Name = "AdriantextBox";
            AdriantextBox.Size = new Size(436, 23);
            AdriantextBox.TabIndex = 5;
            // 
            // PasswordInsert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 212);
            Controls.Add(label3);
            Controls.Add(AdriantextBox);
            Controls.Add(label2);
            Controls.Add(IsraeltextBox);
            Controls.Add(label1);
            Controls.Add(JaviertextBox);
            Controls.Add(GetFileBut);
            Name = "PasswordInsert";
            Text = "PasswordInsert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetFileBut;
        private TextBox JaviertextBox;
        private Label label1;
        private Label label2;
        private TextBox IsraeltextBox;
        private Label label3;
        private TextBox AdriantextBox;
    }
}