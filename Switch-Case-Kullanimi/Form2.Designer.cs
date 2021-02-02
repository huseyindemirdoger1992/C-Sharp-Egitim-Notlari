
namespace Switch_Case_Kullanimi
{
    partial class Form2
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
            this.btnOrnek3 = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.txtGelenDeger2 = new System.Windows.Forms.TextBox();
            this.txtGelenDeger1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOrnek3
            // 
            this.btnOrnek3.Location = new System.Drawing.Point(57, 187);
            this.btnOrnek3.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrnek3.Name = "btnOrnek3";
            this.btnOrnek3.Size = new System.Drawing.Size(193, 30);
            this.btnOrnek3.TabIndex = 4;
            this.btnOrnek3.Text = "ÖRNEK 3";
            this.btnOrnek3.UseVisualStyleBackColor = true;
            this.btnOrnek3.Click += new System.EventHandler(this.btnOrnek3_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Location = new System.Drawing.Point(57, 152);
            this.btnOrnek2.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(193, 30);
            this.btnOrnek2.TabIndex = 5;
            this.btnOrnek2.Text = "ÖRNEK 2";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Location = new System.Drawing.Point(57, 117);
            this.btnOrnek1.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(193, 30);
            this.btnOrnek1.TabIndex = 6;
            this.btnOrnek1.Text = "ÖRNEK 1";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // txtGelenDeger2
            // 
            this.txtGelenDeger2.Location = new System.Drawing.Point(57, 94);
            this.txtGelenDeger2.Margin = new System.Windows.Forms.Padding(2);
            this.txtGelenDeger2.Name = "txtGelenDeger2";
            this.txtGelenDeger2.Size = new System.Drawing.Size(194, 20);
            this.txtGelenDeger2.TabIndex = 2;
            // 
            // txtGelenDeger1
            // 
            this.txtGelenDeger1.Location = new System.Drawing.Point(57, 72);
            this.txtGelenDeger1.Margin = new System.Windows.Forms.Padding(2);
            this.txtGelenDeger1.Name = "txtGelenDeger1";
            this.txtGelenDeger1.Size = new System.Drawing.Size(194, 20);
            this.txtGelenDeger1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 288);
            this.Controls.Add(this.btnOrnek3);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnOrnek1);
            this.Controls.Add(this.txtGelenDeger2);
            this.Controls.Add(this.txtGelenDeger1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrnek3;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.TextBox txtGelenDeger2;
        private System.Windows.Forms.TextBox txtGelenDeger1;
    }
}