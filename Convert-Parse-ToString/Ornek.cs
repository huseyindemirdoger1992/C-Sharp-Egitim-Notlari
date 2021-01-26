using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_Parse_ToString
{
    public partial class Ornek : Form
    {
        public Ornek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             Kullanılabilir karar yapıları
            < Soldaki yapı sağdaki yapıdan küçük ise çalışır
            > Soldaki yapı sağdaki yapıdan büyük ise çalışır
            <= Soldaki yapı sağdaki yapıdan küçük ise veya eşit ise çalışır
            >= Soldaki yapı sağdaki yapıdan büyük ise veya eşit ise çalışır
            == Sol ve sağ yağı birbirlerine eşit ise çalışır
            != soldaki yapı ile sağdaki yapı birbirine eşit değil ise çalışır
             */

            /*
             Kullanılabilir Bağlaç Örnekleri
            && Soldaki ve sağdaki koşullar sağlanır ise çalışır
            || Soldaki yada sağdaki yapıdan herhangi birinin koşulu sağlaması yeterlidir
             */

            if (textBox1.Text != "" && textBox2.Text != "" ) // alanlardan gerhangi biri boş değilse işlem yapar yoksa else kısmı açılır
            {
                double sayi1, sayi2, Sonuc = 0; // Değişkenler oluşturuldu
                sayi1 = int.Parse(textBox1.Text); // parse yöntemi ile metinsel değer sayısal değere çevrildi.
                sayi2 = Convert.ToInt32(textBox2.Text); // convert yöntemi ile metinsel değer sayısal değere çevrildi.

                if (comboBox1.Text == "+") // comboBox1 + seçili ise toplar
                {
                    Sonuc = sayi1 + sayi2;
                    label1.ForeColor = Color.Black;
                }
                else if (comboBox1.Text == "-") // comboBox1 - seçili ise çıkarır
                {
                    Sonuc = sayi1 - sayi2;
                    label1.ForeColor = Color.Black;
                }
                else if (comboBox1.Text == "*") // comboBox1 * seçili ise çarpar
                {
                    Sonuc = sayi1 * sayi2;
                    label1.ForeColor = Color.Black;
                }
                else if (comboBox1.Text == "/")  // comboBox1 / seçili ise böler
                {
                    Sonuc = sayi1 / sayi2;
                    label1.ForeColor = Color.Black;
                }
                else
                {
                    label1.Text = "Girilen Değerleri Kontrol Edin";
                    label1.ForeColor = Color.Red;
                }
                label1.Text = Sonuc.ToString();

            }
            else // alanlardan herhangi biri boş ise bu alan çalışır
            {
                label1.Text = "Girilen Değerleri Kontrol Edin";
                label1.ForeColor = Color.Red;
            }

        }
    }
}
