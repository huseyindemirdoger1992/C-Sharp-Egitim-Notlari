using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ternary_Operatoru_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if veya else if gibi birden fazla koşul oluşturulamaz
            // sadece 2 duruma göre haraket edebilir

            // Örnek
            int x = 7; // Veri tipi oluşturuldu ve değer ataması yapıldı
            string deger = (x / 2 == 0) ? "Sayı çifttir" : "Sayı Tektir" ; // Koşul yazıldı
            /*
             Açıklama
            string deger = işlem sonrası duruma göre değer atanacak yapı olmaktadır
            ? = Soru işareti duruma göre haraket et demek
            (x / 2 == 0) = Koşul geçerli ise 1. yapıyı çalıştıracaktır.("Sayı çifttir")
            (x / 2 == 0) = Koşul geçerli değil ise 2. yapıyı çalıştıracaktır.("Sayı Tektir")
             */
            // Kısa ve kolay ezber yöntemi 
            // string durum = () ? "" : "";

        }
    }
}
