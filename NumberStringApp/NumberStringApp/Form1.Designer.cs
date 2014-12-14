namespace NumberStringApp
{
    partial class Form1
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
            this.AbbButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.NumberListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AbbButton
            // 
            this.AbbButton.Location = new System.Drawing.Point(331, 24);
            this.AbbButton.Name = "AbbButton";
            this.AbbButton.Size = new System.Drawing.Size(75, 23);
            this.AbbButton.TabIndex = 0;
            this.AbbButton.Text = "Add";
            this.AbbButton.UseVisualStyleBackColor = true;
            this.AbbButton.Click += new System.EventHandler(this.AbbButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(143, 33);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberTextBox.TabIndex = 2;
            // 
            // NumberListBox
            // 
            this.NumberListBox.FormattingEnabled = true;
            this.NumberListBox.Location = new System.Drawing.Point(143, 101);
            this.NumberListBox.Name = "NumberListBox";
            this.NumberListBox.Size = new System.Drawing.Size(120, 134);
            this.NumberListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 246);
            this.Controls.Add(this.NumberListBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AbbButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AbbButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.ListBox NumberListBox;
    }
}

