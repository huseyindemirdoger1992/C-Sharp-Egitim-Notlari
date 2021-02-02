using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_If_Yapisi_Break_Kullanimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            string username = txtGelenDeger.Text;
            if (username == "admin")
            {
                // login işlemleri
                MessageBox.Show("Hoşgeldin");
            }
            else
            {
                MessageBox.Show("Tanıyamadım");
                // Dışarı atma işlemleri 
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //Eger girilen not 0'dan kucukse "O'dan küçük bir not girişi yapamazsınız" 100'den buyukse "100'den büyük bir not girişi yapamazsınız" mesajini gostersin...
            int not = int.Parse(txtGelenDeger.Text);
            if (not < 0)
            {
                MessageBox.Show("0'dan küçük not girişi yapamazsınız");
            }
            else if (not > 100)
            {
                MessageBox.Show("100'den büyük not girişi yapamazsınız");

            }
            else
            {
                MessageBox.Show(not.ToString());
            }


            //int not = int.Parse(txtGelenDeger.Text);
            //if(not < 0)
            //{
            //    MessageBox.Show("1. If");
            //}
            //if(not > 100)
            //{
            //    MessageBox.Show("2. If");
            //}
            //else
            //{
            //    MessageBox.Show(not.ToString());
            //}
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //txtGelenDeger'ndan girilen sayi cift ise "Sayı Çifttir" tek ise "Sayı Tektir" mesajini kullaniciya gosteriniz...
            int sayi = int.Parse(txtGelenDeger.Text);
            if (sayi % 2 == 0)
            {
                MessageBox.Show("Sayı Çifttir");
            }
            else
            {
                MessageBox.Show("Sayı Tektir");
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //Disaridan girilen kelimenin uzunlugu 8 karaktere esit ya da buyukse kayit onaylandi, degilse daha uzun bir sifre giriniz...

            if (txtGelenDeger.Text.Length >= 8)
            {
                MessageBox.Show("Kayıt Onaylandı");
            }
            else
            {
                MessageBox.Show("Daha uzun bir şifre seçiniz");
            }
        }
    }
}
