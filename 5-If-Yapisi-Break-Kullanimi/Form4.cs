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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        // random verdiğiniz max değerin her zaman bir alt değerini size teslim eder.

        private void Form4_Load(object sender, EventArgs e)
        {
            lblSayi.Text = rnd.Next(10000000, 100000000).ToString();


            // min = 1, max = 50 => üretebileceği en max değer 49
            /*
             Form yüklendiğinde ilgilie label'a karmaşık olarak 8 haneli bir değer yazdırınız
             Kullanıcı textbox'a değeri girdiğinde eğer birbirlerine eşit ise, giriş yaptınız uyarısı verdiriniz.
             Kullanıcı değeri yanlış girerse,
             1) yeni bir karmaşık sayı üretiniz.
             2) textbox'ı temizleyiniz 
             3) Kalan hakkı 1 eksiltiniz.

             Kullanıcı 5 defa yanlış girerse ( kalan hak 0'a eşit olursa) Butonun aktiflik özelliğini kapatınız.
             */

        }
    }
}
