using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
           Sahip oldugunuz metinsel degerlerin ozelliklerini degistirmek icin kullanilan metotlardir. Ornegin, kelimeleri parcalamak, eklemek, harflerin yerlerini degistirmek, bosluk temizlemek vs...   
         */

        string gelen_deger;
        string kontrol_deger;

        #region Compare
        private void btnCompare_Click(object sender, EventArgs e)
        {
            //CompareTo => Metodu kullandiginiz string degerle metoda verdiginiz parametredeki string degeri sozluk mantigiyla karsilastirir... Eger sozlukte ayni lokasyonlardasa 0, parametredeki deger, ana degerimizden sozlukte onceyse -1; sonraysa 1 degerini dondurur...

            kontrol_deger = txtKontrolDeger.Text;
            gelen_deger = txtGelenDeger.Text;

            int result = kontrol_deger.CompareTo(gelen_deger);
            string mesaj = "";
            switch (result)
            {
                case -1:
                    mesaj = "Kelime diğer kelime ile eşleşmeketedir. Eksik karakter var";
                    break;
                case 0:
                    mesaj = "Tebrikler! Kelimeler eşleşmektedir";
                    break;
                case 1:
                    mesaj = "Kelime diğer kelime ile eşleşmemektedir. Fazla karakter var";
                    break;
                default:
                    break;
            }
            MessageBox.Show(mesaj);
        }
        #endregion

        #region Contains
        private void btnCotains_Click(object sender, EventArgs e)
        {
            // Contains() => içeriyormu, parametrede gönderdiğiniz değer, metin içerisinde geçiyormu, geçmiyormu size bool olarak geri döner.
            gelen_deger = txtGelenDeger.Text;
            kontrol_deger = txtKontrolDeger.Text;
            bool result = gelen_deger.Contains(kontrol_deger);
            MessageBox.Show($"Aradığınız \"{kontrol_deger}\" parametresi, \"{gelen_deger}\" içerisinde {(result ? "geçmektedir" : "geçmemektedir")}");
        }
        #endregion

        #region Startswith
        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            //StartsWith => Kelimenizin parametrede gonderdiginiz deger ile baslayip baslamadigini size "bool" olarak dondurur...
            gelen_deger = txtGelenDeger.Text;
            kontrol_deger = txtKontrolDeger.Text;

            bool result = gelen_deger.StartsWith(kontrol_deger);

            //MessageBox.Show(result ? "Kelime Parametrede Gönderdiğiniz Değer İle Başlamaktadır" : "Kelime Parametrede Gönderdiğiniz Değer İle Başlamamaktadır");

            MessageBox.Show($"\"{gelen_deger}\" kelimesi, \"{kontrol_deger}\" parametresi ile {(result ? "başlamaktadır" : "başlamamaktadır")}", "Kontrol Bildirimi", MessageBoxButtons.OK, result ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }
        #endregion

        #region EndsWith
        private void btnEndsWith_Click(object sender, EventArgs e)
        {
            //EndsWith => Kelimenizin parametrede gonderdiginiz degerle bitip bitmedigini size "bool" olarak dondurur...
            gelen_deger = txtGelenDeger.Text;
            kontrol_deger = txtKontrolDeger.Text;

            bool result = gelen_deger.EndsWith(kontrol_deger);

            //MessageBox.Show(result ? "Kelime Parametrede Gönderdiğiniz Değer İle Başlamaktadır" : "Kelime Parametrede Gönderdiğiniz Değer İle Başlamamaktadır");

            MessageBox.Show($"\"{gelen_deger}\" kelimesi, \"{kontrol_deger}\" parametresi ile {(result ? "bitmektedir" : "bitmemektedir")}", "Kontrol Bildirimi", MessageBoxButtons.OK, result ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }
        #endregion

        #region IndexOf 
        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //IndexOf => Dizilerde gordugumuz metodun ayni prensibleriyle calisir. Eger harf varsa harfin indexini, yoksa -1 degerini, harf birden fazla var ise ilk harfin indexini dondurur...

            gelen_deger = txtGelenDeger.Text;
            kontrol_deger = txtKontrolDeger.Text;

            int result = gelen_deger.IndexOf(kontrol_deger);
            MessageBox.Show($"Metin içerisinde aranılan karakterin index numarası : {result}");
        }
        #endregion

        #region LastIndexOf

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            //LastIndexOf => Dizilerde gordugumuz metodun ayni prensibiyle calisir. Eger harf varsa harfin indexini, yoksa - 1 degerini, harf birden fazla varsa son harfin indexini dondurur...

            gelen_deger = txtGelenDeger.Text;
            kontrol_deger = txtKontrolDeger.Text;

            int result = gelen_deger.LastIndexOf(kontrol_deger);
            MessageBox.Show($"Metin içerisinde aranılan karakterin son index numarası : {result}");

        }
        #endregion

        #region Remove
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //NOT => Bir string uzerinde yaptiginiz degisiklikler o string'i degistirmez, size yeni bir kopyasini teslim eder...
            //Remove (1.Kullanım) => Verdiginiz index numarasi dahil, o indexteki ve sonraki tum karakterleri ortadan kaldirir...

            gelen_deger = txtGelenDeger.Text;
            gelen_deger = gelen_deger.Remove(
                int.Parse(txtKontrolDeger.Text) // silme işlemi için başlangıç index değeri
                );

            MessageBox.Show(gelen_deger);


            //Remove (2.Kullanım) => Verdiginiz index numarasi dahil, o indexteki elemandan baslayarak, ikinci parametrede gonderdiginiz deger kadar eleman siler...

            gelen_deger = txtGelenDeger.Text;
            gelen_deger = gelen_deger.Remove(
                int.Parse(txtKontrolDeger.Text), // silme işlemi başlangıç index değeri
                int.Parse(txtCount.Text)       // başlangıç index değerinden sonra başlayarak (index numarası dahil) silinecek eleman sayısı
                );
            MessageBox.Show(gelen_deger);
        }
        #endregion

        #region Replace
        private void btnReplace_Click(object sender, EventArgs e)
        {
            //Replace => Metniniz icerisindeki bir karakteri ya da bir bolumu yeni bir karakter - bolum - ile degistirmenize olanak saglar..
            gelen_deger = txtGelenDeger.Text;
            kontrol_deger = txtKontrolDeger.Text;
            string yeni_deger = txtCount.Text;
            gelen_deger = gelen_deger.Replace(kontrol_deger, yeni_deger);
            MessageBox.Show(gelen_deger);

            // gelen_deger üzerinde yer alan türkçe karakterleri temizleyip kullanıcya gösteriniz :)

            gelen_deger = gelen_deger
                .ToLower()
                .Replace("ş", "s")
                .Replace("ğ", "g")
                .Replace("ü", "u")
                .Replace("ç", "c")
                .Replace("ö", "o")
                .Replace("ı", "i")
                .Replace(" ", "");

            MessageBox.Show(gelen_deger);
        }
        #endregion

        #region Split
        private void btnSplit_Click(object sender, EventArgs e)
        {
            //Split => Metninizi ozel bir karakterden birden fazla parcaya ayirmaniza olanak saglayan metottur Ayni anda birden fazla ozel karakter de verebilirsiniz...

            gelen_deger = txtGelenDeger.Text;
            string[] mail_adresler = gelen_deger.Split(';', '+', ',', '-');
            foreach (string str in mail_adresler)
            {
                MessageBox.Show(str);
            }


            // mail adresleri ayrıma için kullanılacak karakterler : + , ; - gibi bunlarıda dahil ediniz 
        }
        #endregion

        #region Insert
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Insert => Bir metinsel degerin herhangi bir pozisyonuna (index) yeni bir degeri ilistirmek istiyorsaniz bu metodu kullanabilirsiniz. İlk parameterde kacinci indexten sonra ekleyecegini, ikinci parametrede ise hangi metni ekleyecegini sorar...
            gelen_deger = txtGelenDeger.Text;
            kontrol_deger = txtKontrolDeger.Text;
            gelen_deger = gelen_deger.Insert(int.Parse(txtCount.Text), kontrol_deger);
            MessageBox.Show(gelen_deger);
        }
        #endregion

        #region ToLower - ToUpper
        private void btnLowerUpper_Click(object sender, EventArgs e)
        {
            //ToLower => İlgili metnin tamamını küçük harfe çevirmenize olanak saglar..
            //ToUpper => İlgili metnin tamamini buyuk harfe cevirmenize olanak saglar..

            gelen_deger = txtGelenDeger.Text;
            MessageBox.Show(gelen_deger.ToLower() + "\n" + gelen_deger.ToUpper());
        }
        #endregion

        #region Substring
        private void btnSubstring_Click(object sender, EventArgs e)
        {
            //Substring (1.Kullanım) => Metninizden, parametrede gonderdiginiz indexten baslayarak, geri kalan kismi cekip almaniza olanak saglar...

            gelen_deger = txtGelenDeger.Text;
            kontrol_deger = txtKontrolDeger.Text;

            gelen_deger = gelen_deger.Substring(int.Parse(kontrol_deger));
            MessageBox.Show(gelen_deger);


            //Substring (2.Kullanım) => Metninizden, ilk parametrede verdiginiz indexten baslayip, ikinci parametrede verdiginiz deger kadarlik kismi cekip almaniza olanak saglar..

            gelen_deger = txtGelenDeger.Text;
            kontrol_deger = txtKontrolDeger.Text;
            gelen_deger = gelen_deger.Substring(int.Parse(kontrol_deger), int.Parse(txtCount.Text));
            MessageBox.Show(gelen_deger);
        }
        #endregion

        #region ToCharArray
        private void btnToCharArray_Click(object sender, EventArgs e)
        {
            //ToCharArray => Stringinizi charlarina ayirarak size char[] olarak teslim eder...

            gelen_deger = txtGelenDeger.Text;
            // 1. Kullanım var olan bütün string değeri char dizisine çevirip size teslim eder.
            char[] karakterler = gelen_deger.ToCharArray();
            //ORNEK: disaridan girilen metindeki her bir karakterin ASCII degerleri toplami kactir?
            int toplam = 0;
            for (int i = 0; i < karakterler.Length; i++)
            {
                toplam += karakterler[i];
            }
            MessageBox.Show(toplam.ToString());

            // 2. Kullanım var olan metin içerisinden 1. parametrede verdiğiniz index değerinden başlayarak, 2. parametrede verdiğiniz adet kadar size teslim eder.
            gelen_deger = txtGelenDeger.Text;
            char[] letters = gelen_deger.ToCharArray(0, 4);
        }
        #endregion

        #region Trim
        private void btnTrim_Click(object sender, EventArgs e)
        {
            //Trim => Metninizin saginda ya da solundaki tum bosluklari temizlemenize olanak saglayan metottur... ( metin içerisinde yer alan boşlukları temizlemez)

            // Trim()      => Soldaki ve sağdaki boşlukları temizler
            // TrimEnd()   => Sağdaki boşlukları temizler
            // TrimStart() => Soldaki boşlukları temizler

            gelen_deger = txtGelenDeger.Text;
            kontrol_deger = gelen_deger.Trim();

            MessageBox.Show($"Metin içerisinde yer alan toplam karakter sayısı : {gelen_deger.Length}\nMetinin boşlukları temizlenerek hesaplanan karakter sayısı : {kontrol_deger.Length}");
        }
        #endregion

    }
}
