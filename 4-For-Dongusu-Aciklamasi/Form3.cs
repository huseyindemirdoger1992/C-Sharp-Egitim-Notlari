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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide yer alan her bir elemani, listbox icerisine ekleyiniz...
            string[] takimlar = { "Galatasaray", "Fenerbahce", "Besiktas", "Trabzonspor", "Bursaspor", "Ankaragücü" };
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            // Array sınıfını kullanmadan o dizinin en buyuk elemanini gosterin...
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6 };
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide kac tane cift kac tane tek sayi vardir kullaniciyi bilgilendiriniz..
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6, 25 };
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //asagidaki "adim" degiskeninde yer alan metni tersten isterseniz formun tepesine, isterseniz MessageBox'la yazdiriniz...

            //NOT => STRING'LER BİRER CHAR DİZİSİDİR...
            string adim = "bilgeadam";
            // madaeglib
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            //Karmasik 10 adet sayiyi listbox icerisine ekleyiniz...
        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            //Form uzerinde yer alan tum butonlarin arkaplan renkleri kırmızı, yazi renkleri ise sarı olsun...

            //Eger icinde bulundugunuz forma isaret etmek istiyorsaniz, kullanacaginiz anahtar kelime "this" anahtar kelimesidir...
        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            //Disaridan girilen sayisal ifadenin rakam degerleri toplamini gosteriniz...
            //Ornegin 123 girilirse 1+2+3 = 6 sonucu donmelidir... 
        }

    }
}
