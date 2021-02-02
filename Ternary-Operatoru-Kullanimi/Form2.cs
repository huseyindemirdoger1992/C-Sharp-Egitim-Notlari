using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ternary_Operatoru_Kullanimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            bool sonuc = 10 > 2;

            if (sonuc)
            {
                MessageBox.Show("Kayıt Eklendi");
            }
            else
            {
                MessageBox.Show("İşlem Hatası");
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            bool sonuc = 10 > 2;
            switch (sonuc)
            {
                case true:
                    MessageBox.Show("Kayıt Eklendi");
                    break;
                case false:
                    MessageBox.Show("İşlem Hatası");
                    break;
            }
        }
        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            bool sonuc = 10 > 9;
            MessageBox.Show(sonuc ? "Kayıt Eklendi" : "İşlem Hatası");
            // ? true gelir ise
            // : false gelirse

            MessageBox.Show(textBox1.Text.Length > 0 ? textBox1.Text : "TextBox alanı boş geçilemez");

        }
    }
}
