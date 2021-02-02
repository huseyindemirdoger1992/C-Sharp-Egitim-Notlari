
namespace Aritmetiksel_Ornekler
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
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Location = new System.Drawing.Point(33, 83);
            this.btnOrnek1.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(161, 37);
            this.btnOrnek1.TabIndex = 8;
            this.btnOrnek1.Text = "ÖRNEK";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(33, 60);
            this.txtSayi2.Margin = new System.Windows.Forms.Padding(2);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(162, 20);
            this.txtSayi2.TabIndex = 6;
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(33, 38);
            this.txtSayi1.Margin = new System.Windows.Forms.Padding(2);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(162, 20);
            this.txtSayi1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 203);
            this.Controls.Add(this.btnOrnek1);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
    }
}

