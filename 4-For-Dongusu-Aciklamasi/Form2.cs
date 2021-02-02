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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //DONGULER - LOOPS
            //Bir baslangic degeri olan, belirli bir kosul gerceklesene dek suren ve bu surec icerisinde bir takim islemleri tekrarli olarak gerceklestiren nesnelere "dongu" adini vermekteyiz.
            //FOR - FOREACH - WHILE - DOWHILE

        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            // 1. Parametre " int i = 1; " Baçlagıç Değeri
            // 2. Parametre Koşul " i <= 1000; " 1000 olana kadar devam et
            // 3. Parametre İterasyon " i++ " döngü değeri kaç adet arttırılacak
            for (int i = 1; i <= 1000; i++)
            {
                lstElemalnar.Items.Add(i);
            }

            #region Sonsuz döngü örnek
            //int a = 1;
            //for(; ; )
            //{
            //    lstElemalnar.Items.Add("ads");

            //    if(a == 1000)
            //    {
            //        break;
            //    }
            //    a++;
            //} 
            #endregion
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            // 1000 ile 1 arasındaki sayıları listbox'a ekleyiniz.
            for (int i = 1000; i >= 1; i--)
            {
                lstElemalnar.Items.Add(i);
            }
        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            // 1 ile 1000 arasındaki çift sayıları listbox'a ekleyiniz.
            for (int i = 0; i <= 1000; i += 2)
            {
                lstElemalnar.Items.Add(i);
            }

        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            // A'dan Z'ye alfabeyi listbox'a ekleyiniz :)

            for (char i = 'A'; i <= 'Z'; i++)
            {
                lstElemalnar.Items.Add(i + " - " + Convert.ToInt32(i));

            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //1-100 arasındaki sayilarin toplamini ekrana yazdiriniz.
            int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                toplam += i;
            }
            MessageBox.Show("Sayıların Toplam Değeri : " + toplam);
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            //1-100 arasindaki cift sayilarin toplami ile, tek sayilarin toplaminin farklari karesi kactir?

            int tekSayilar = 0, ciftSayilar = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    ciftSayilar += i;
                else
                    tekSayilar += i;
            }

            int sonuc = (ciftSayilar - tekSayilar) * (ciftSayilar - tekSayilar);
            MessageBox.Show("işlem Sonucu " + sonuc);
        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            //1945 - günümüz yılı arasındaki yıllar Listbox'a eklensin ancak 1990 ve 1992 yılları eklenmeyecek...

            for (int i = 1945; i < DateTime.Now.Year; i++)
            {
                if (i != 1990 && i != 1992)
                {
                    lstElemalnar.Items.Add(i);
                }
            }
        }
    }
}
