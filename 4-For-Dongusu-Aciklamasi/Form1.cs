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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // FOR Döngüsü Kullanımı

            for (int i = 0; i < 10; i++)
            {
                // int i = 0;   1. yapıda değişken tipi(int) belirlenir ve değişken attanır. Başlangıç noktası atanır.
                // i < 10;      2. yapıda ise değişken sınırı belirlenir
                // i++          3. yapıda ise artış mikratı belirtilir.
            }


            for (uint i = 0; i < 900; )
            {
                // uint i = 0;   1. yapıda değişken tipi(uint) belirlenir ve değişken attanır. Başlangıç noktası atanır.
                // i < 10;      2. yapıda ise değişken sınırı belirlenir
                // i++          3. yapıda ise artış mikratı belirtilir.
            }


            for (double i = 1000; i < 9900; i += 2)
            {
                // double i = 1000;   1. yapıda değişken tipi(double) belirlenir ve değişken attanır. Başlangıç noktası atanır.
                // i < 10;      2. yapıda ise değişken sınırı belirlenir
                // += 2         3. yapıda ise artış mikratı belirtilir. 2 şer olarak sayarak artar
            }

            for (long i = 0; i < 9900; i -= 2)
            {
                // long i = 0;   1. yapıda değişken tipi(long) belirlenir ve değişken attanır. Başlangıç noktası atanır.
                // i < 10;      2. yapıda ise değişken sınırı belirlenir
                // -= 2         3. yapıda ise artış mikratı belirtilir. 2 şer olarak sayarak eksilir
            }

        }
    }
}
