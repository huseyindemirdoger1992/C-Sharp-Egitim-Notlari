using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        /*
  Geriye deger dondurmeyen, yalnizca uzerine dusen isi yapan işlemlerle void metotlar ya da subrutinler denir...
  1) Tekrarlı kodlari engellemek...
  2) Kod kalabaligindan kurtulup daha esnek kodlar yazabilmek...
  3) Merkeziyetci kod yapisini hedef haline getirebilmek. Yani, herhangi bir problem ya da degisiklik durumunda birden fazla yeri kontrol etmek yerine, merkez yapiya mudahele ederek en kısa ve en net sekilde sorunlari cozmek..
*/


        #region Örnek 1
        void Saydirici()
        {
            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            Saydirici();
        }
        #endregion

        #region Örnek 2
        void AmeleMetot()
        {
            this.Width = 400;
            this.Height = 400;
            //this.Size = new Size(400, 400);
            this.BackColor = Color.White;
        }
        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            // Form genişliği 400;400 arkaplan rengi beyaz. Bu işlemleri gerçekleştirecek bir metot yazınız :)
            AmeleMetot();
        }
        #endregion


        /*
            PARAMETRELİ METOTLAR
            Disaridan gelecek olan degerlere gore islem yonunu degistirecek olan metotlardir...
            Parametredeki degiskene, iceride deger atanmaz!
            Metot prensipleri geregi, parametrenin nereden gelecegi soylenmez....
        */

        #region Örnek 3
        void ParametreliSaydir(int sayi)
        {
            //sayi = 100; => yanlış kullanım, parametreye içeriden değer atanmaz
            //sayi = Convert.ToInt32(txtGirisAlani.Text); => yanlış kullanım, parametreye dışarıdan gelecek olan değer, metot içerisinde belirilmez.

            for (int i = 1; i <= sayi; i++)
            {
                listBox1.Items.Add(i);
            }
        }
        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            ParametreliSaydir(int.Parse(txtGirisAlani.Text));
        }
        #endregion

        #region Örnek 4
        void HesapMakinesi(int s1, int s2)
        {
            int toplam = s1 + s2;
            int sonuc = Convert.ToInt32(Math.Pow(toplam, 3));
            MessageBox.Show(sonuc.ToString());
        }
        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            //Disaridan girilen iki sayinin toplaminin kupunu MessageBox'la gosterecek bir metot yaziniz...
            HesapMakinesi(int.Parse(txtBirinciSayi.Text), int.Parse(txtIkinciSayi.Text));
        }
        #endregion

        #region Örnek 5
        void RenkDegistir(string renk)
        {
            this.BackColor = Color.FromName(renk);
        }
        private void btnArkaPlanDegistir_Click(object sender, EventArgs e)
        {
            //Combobox'tan secilen rengi formun arkaplanina atayan bir metot yaziniz...
            RenkDegistir(cmbRenkler.Text);
        }
        #endregion

        void SonUcHarf(string param)
        {
            //string mesaj = "";
            //if (param.Length <= 3)
            //{
            //    mesaj = param;
            //}
            //else
            //{
            //    mesaj = param.Substring(param.Length - 3);
            //}
            //MessageBox.Show(mesaj);
            MessageBox.Show(param.Length <= 3 ? param : param.Substring(param.Length - 3));
        }
        private void btnKirp_Click(object sender, EventArgs e)
        {
            //Disaridan girilen degerin son 3 harfini messageBoxla bir metot yaziniz. Ancak girilen deger 3 harften azsa ya da 3 harfe esitse direkt olarak tamamini gostersin...
            SonUcHarf(txtGirilenMetin.Text);
        }
    }
}
