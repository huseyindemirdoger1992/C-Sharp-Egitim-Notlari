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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            /*
* MANTIKSAL OPERATORLER
* Birden fazla durumun ayni anda kontrol edilmesi senaryosunda kullanilan operatorlerdir...
* && (VE) (Kontrol blogu icerisinde yer alan tum kosullarin saglanmasi durumuna isaret eder... Kosullardan biri dahi saglanmazsa blogunuz harekete gecmez...)
* || (VEYA) (Kontrol blogu icerisinde yer alan kosullardan herhangi birinin saglanmasi durumuna isaret eder... Boylece bir kosul bile saglansa blogunuza yazdiginiz kodlar harekete gecer...) Kısayol => ALTGR + Tire
* 
* Yukarıdaki operatorlere "kısa devre operatoru (shortcut operator)" adi verilir.. Kosullari kontrole en soldan baslar, herhangi bir uygunsuzluk durumunda diger kosullara asla bakmaz!.. Asagidaki operatorlerde ise, kosullar uysun ya da uymasin hepsi kontrol edilir...
* 
* & => VE
* | => VEYA
*/



            //(1 == 1 && 2 == 1) false
            //(1 == 1 && 2 == 2) true


            //(1 == 1 || 2 == 1)  true
            //(1 == 1 || 2 == 2)  true
            //(1 == 2 || 2 == 1)  false

        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //string username = txtGelenDeger1.Text;
            //string password = txtGelenDeger2.Text;

            //string username, password;
            //username = txtGelenDeger1.Text;
            //password = txtGelenDeger2.Text;

            string username = txtGelenDeger1.Text, password = txtGelenDeger2.Text;
            //if (username == "admin")
            //{
            //    if (password == "123")
            //    {
            //        MessageBox.Show("Hoşgeldiniz");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Kullanıcı Bilgileriniz Yanlış");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı Bilgileriniz Yanlış");
            //}


            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Hoşgeldiniz");
            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgileriniz Yanlış");
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            // Dışarıdan not girişi yapılacak, girilen not aşağıdaki tablo ile karşılaştırılıp kullanıcının notuna göre Harf notunu MB içerisinde gösteriniz :)
            /* 
             AA - 85 aralığı 100
             BB - 70 aralığı 84
             CC - 50 aralığı 69
             DD - 0  aralığı 49 
             */

            int not = int.Parse(txtGelenDeger1.Text);
            if (not >= 0 && not <= 49)
            {
                MessageBox.Show("Harf Notunuz - DD");
            }
            else if (not >= 50 && not <= 69)
            {
                MessageBox.Show("Harf Notunuz - CC");
            }
            else if (not >= 70 && not <= 84)
            {
                MessageBox.Show("Harf Notunuz - BB");
            }
            else if (not >= 85 && not <= 100)
            {
                MessageBox.Show("Harf Notunuz - AA");
            }
            else
            {
                MessageBox.Show("Geçersiz Not Girişi");
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Disaridan urun adi girilecek, kasiyer bize urunun hangi reyonda oldugunu soyleyecek...
            //Domates, Biber, Patlican => Sebze Reyonu
            //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //Disaridan siparis alinacak olan kitap miktari girilsin. Sipari sayisi 20'den azsa toplam ucretten %5, 20 - 50 araliginda ise %10, 50-100 araligi ise %15, 100'den fazla ise %25 indirim yapilsin. Kitabın birim fiyatı => 5 TLdir... Amac => Odenecek tutari kullaniciya gostermek...
        }

    }
}
