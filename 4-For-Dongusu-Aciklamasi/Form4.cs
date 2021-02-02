using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_For_Dongusu_Aciklamasi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            // label'a  Yan yana 5 adet X yazdırınız
            for (int i = 0; i < 5; i++)
            {
                label1.Text += "X ";
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            // label'a  Alt alta 5 adet X yazdırınız
            for (int i = 0; i < 5; i++)
            {
                label1.Text += "X\n";
            }
        }
        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            /*
                x
                x x
                x x x
                x x x x
                x x x x x
                x x x x x x
                x x x x x x x 
             */

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    label1.Text += "X ";
                }
                label1.Text += "\n";
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            // x ile içi dolu kare çiziniz.
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    label1.Text += "X ";
                }
                label1.Text += "\n";
            }
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            // 1'den 10'a kadar çarpım tablosunu listbox'a ekleyiniz. Format 

            // 1 X 1 = 1
            // 1 X 10 = 10
            // ----------------------
            // 2 X 1 = 2
            // 10 X 10 = 100

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    listBox1.Items.Add($"{i} X {j} = {i * j}");
                }
                listBox1.Items.Add("------------------------");
            }
        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            // break  // eğer belirttiğiniz koşul sağlandı ise, ilgili döngüyü sonlandırır.

            for (int i = 1; i < 50; i++)
            {
                if (i == 5)
                {
                    listBox1.Items.Add(i);
                    break;
                }
                listBox1.Items.Add(i);
            }
            MessageBox.Show("Listeye Ekleme İşlemi Tamamlandı");
        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            // continue
            listBox1.Items.Clear();
            Random rnd = new Random();
            for (int i = 1; i < 7; i++)
            {
                int sayi = rnd.Next(1, 50);
                if (listBox1.Items.Contains(sayi))
                {
                    i--;
                    continue;
                }
                listBox1.Items.Add(sayi);
            }
        }

        private void btnOrnek8_Click(object sender, EventArgs e)
        {
            // return
            for (int i = 0; i < 50; i++)
            {
                if (i == 5)
                    //return;

                    listBox1.Items.Add(i);
            }
            MessageBox.Show("Yukarıdaki işlemlerim bitti, Sonraki kod bloklarına geçtim");

            // username password  
            string username = "123", password = "123";
            if (username == "" || password == "")
            {
                MessageBox.Show("Kullanıcı Bilgilerinizi Giriniz");
                return;
            }
            MessageBox.Show("Kullanıcı Giriş İşlemleri");
            // Login işlemleri

        }

    }
}
