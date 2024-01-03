namespace PDFtoBase
{
    partial class MainWindows
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
            ToBase = new Button();
            PathBox = new TextBox();
            FromBase = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ToBase
            // 
            ToBase.Location = new Point(568, 24);
            ToBase.Margin = new Padding(3, 2, 3, 2);
            ToBase.Name = "ToBase";
            ToBase.Size = new Size(82, 22);
            ToBase.TabIndex = 0;
            ToBase.Text = "ToBase";
            ToBase.UseVisualStyleBackColor = true;
            ToBase.Click += button1_Click;
            // 
            // PathBox
            // 
            PathBox.Location = new Point(33, 34);
            PathBox.Margin = new Padding(3, 2, 3, 2);
            PathBox.Name = "PathBox";
            PathBox.Size = new Size(495, 23);
            PathBox.TabIndex = 1;
            // 
            // FromBase
            // 
            FromBase.Location = new Point(568, 50);
            FromBase.Margin = new Padding(3, 2, 3, 2);
            FromBase.Name = "FromBase";
            FromBase.Size = new Size(82, 22);
            FromBase.TabIndex = 3;
            FromBase.Text = "FromBase";
            FromBase.UseVisualStyleBackColor = true;
            FromBase.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "PathBox";
            // 
            // MainWindows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 84);
            Controls.Add(label1);
            Controls.Add(FromBase);
            Controls.Add(PathBox);
            Controls.Add(ToBase);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainWindows";
            Text = "MainWindows";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ToBase;
        private TextBox PathBox;
        private Button FromBase;
        private Label label1;
    }
}