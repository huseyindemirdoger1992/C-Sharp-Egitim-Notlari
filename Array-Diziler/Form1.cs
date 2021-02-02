using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ARRAY - DİZİ
        //Birden fazla aynı tipteki veriyi bir arada tutmamizi saglayan nesnelerimizdir...

        //EĞER;
        //Index was outside the bounds of the array.
        //hatası aliyorsaniz, bilin ki dizinin boyutlarini asacak sekilde eleman ekleme cabasindasiniz... Hata nerde diye bakma, eleman ekleme islemlerine git!

        private void button1_Click(object sender, EventArgs e)
        {
            // sehirler
            // personeller
            // öğrenciler
            // maaşlar
            // yaşlar


            // sayılar dizisi içerisinde toplamda 4 eleman barındırabilirsiniz.

            // 1. Tanımlama Yöntemi
            int[] sayilar = new int[4];
            sayilar[0] = 38;  // 1. Eleman
            sayilar[1] = 2;   // 2. Eleman
            sayilar[2] = 34;  // 3. Eleman
            sayilar[3] = 35;  // 4. Eleman
            //sayilar[4] = 23;  // 5. Eleman

            // eleman sayısı :  1 ankara  'D'  12.5
            // index değeri  :  0   1      2    3

            // 2. Tanımlama Yöntemi
            string[] sehirler = new string[5] {
                "Ankara",    // 0 değerini verirseniz Anraka
                "Edirne",    // 1 değerini verirseniz Edirne
                "İstanbul",  // 2 değerini verirseniz İstanbul
                "Eskişehir", // 3 değerini verirseniz Eskişehir
                "Bursa"      // 4 değerini verirseniz Bursa
            };


            // maximum index değeri her zaman eleman sayısının bir alt değeridir
            //MessageBox.Show(sehirler[1]);


            char[] karakterler = { 'A', 'B', 'C', 'D' };
        }
    }
}
