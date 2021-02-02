using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematiksel_Operatorler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 102;
            int sayi2 = 20;
            int toplam = sayi1 + sayi2;

            // Not : metinsel değerleri + ile yan yana yazarsanız, birleştirme işlemi gerçekleşir, sayısal değerlerde ise matematiksel anlamda toplama işlemi gerçekleşir

            int sayi3 = 1244;
            int sayi4 = 324;
            int fark = sayi3 - sayi4;



            long sayi5 = 213;
            long sayi6 = 23;
            long carpma = sayi5 * sayi6;

            double sayi7 = 234;
            double sayi8 = 23;
            double bolme = sayi7 / sayi8;


            int sayi9 = 12;
            int sayi10 = 5;
            int mod = sayi9 % sayi10; //Mod alma (kalan hesaplama)

            // Fark işlemi, Çarpma, Bölme ve Mod alma işlemlerini yapmanı


            // Sayıların bir üst değere ve bir alt değere taşınması

            int sayi = 15;

            sayi = sayi + 1;
            sayi += 1;
            sayi++;

            sayi = sayi - 1;
            sayi -= 1;
            sayi--;

        }
    }
}
