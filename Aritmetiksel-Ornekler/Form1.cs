using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aritmetiksel_Ornekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //Disaridan alinan iki sayının toplamiyla farkinin birbirine bolumunden kalanin sonucu kactir? (Farkın toplama bolumunden kalan kactir?)

            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;

            int mod = toplam % fark;
            MessageBox.Show("İşlem Sonucu : " + mod);
        }
    }
}
