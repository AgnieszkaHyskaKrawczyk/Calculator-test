namespace Calculator_test
{
    partial class Calculator
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
            this.textNumber1 = new System.Windows.Forms.TextBox();
            this.textNumber2 = new System.Windows.Forms.TextBox();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textNumber1
            // 
            this.textNumber1.Location = new System.Drawing.Point(89, 168);
            this.textNumber1.Name = "textNumber1";
            this.textNumber1.Size = new System.Drawing.Size(100, 20);
            this.textNumber1.TabIndex = 0;
            // 
            // textNumber2
            // 
            this.textNumber2.Location = new System.Drawing.Point(227, 168);
            this.textNumber2.Name = "textNumber2";
            this.textNumber2.Size = new System.Drawing.Size(100, 20);
            this.textNumber2.TabIndex = 1;
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(345, 168);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(75, 23);
            this.buttonEqual.TabIndex = 2;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.ButtonEqual_Click);
            // 
            // textResult
            // 
            this.textResult.Enabled = false;
            this.textResult.Location = new System.Drawing.Point(438, 171);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(100, 20);
            this.textResult.TabIndex = 3;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.textNumber2);
            this.Controls.Add(this.textNumber1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumber1;
        private System.Windows.Forms.TextBox textNumber2;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.TextBox textResult;
    }
}

