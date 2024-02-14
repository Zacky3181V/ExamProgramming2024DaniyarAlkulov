namespace ExpensesManager
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
            label1 = new System.Windows.Forms.Label();
            pathBox = new System.Windows.Forms.TextBox();
            readButton = new System.Windows.Forms.Button();
            statsButton = new System.Windows.Forms.Button();
            resultBox = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "path";
            // 
            // pathBox
            // 
            pathBox.Location = new System.Drawing.Point(88, 19);
            pathBox.Name = "pathBox";
            pathBox.Size = new System.Drawing.Size(526, 23);
            pathBox.TabIndex = 1;
            pathBox.Text = "C:\\Program Files (x86)\\Invoices.txt";
            pathBox.TextChanged += pathBox_TextChanged;
            // 
            // readButton
            // 
            readButton.Location = new System.Drawing.Point(23, 76);
            readButton.Name = "readButton";
            readButton.Size = new System.Drawing.Size(95, 37);
            readButton.TabIndex = 2;
            readButton.Text = "Read";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += readButton_Click;
            // 
            // statsButton
            // 
            statsButton.Location = new System.Drawing.Point(174, 78);
            statsButton.Name = "statsButton";
            statsButton.Size = new System.Drawing.Size(96, 32);
            statsButton.TabIndex = 3;
            statsButton.Text = "Stats";
            statsButton.UseVisualStyleBackColor = true;
            statsButton.Click += statsButton_Click;
            // 
            // resultBox
            // 
            resultBox.Location = new System.Drawing.Point(12, 119);
            resultBox.Multiline = true;
            resultBox.Name = "resultBox";
            resultBox.Size = new System.Drawing.Size(776, 319);
            resultBox.TabIndex = 4;
            resultBox.TextChanged += resultBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(resultBox);
            Controls.Add(statsButton);
            Controls.Add(readButton);
            Controls.Add(pathBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.TextBox resultBox;
    }
}
