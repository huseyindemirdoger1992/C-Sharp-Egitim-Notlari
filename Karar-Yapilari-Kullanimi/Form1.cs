using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if kullanımında şartın gerçekleşmesi durumunda hangi işlemlerin yapılacağı ayrı ayrı yazılabilir.

            // Koşul parantez içerisinde yazılır ve eğer koşul sağlanıyor ise skop alanlarına girmenize izin verir
            if (true)
            {

            }
            //-----------------------------------------------------------------------------------------------------

            // Else ise belirtilen koşul eğer sağlanamaz ise çalışan ortamdır. bu şekilde if skop alanları değil else skop alanları çalışmaktadır.
            if (true)
            {

            }
            else
            {

            }
            //-----------------------------------------------------------------------------------------------------

            // Birden fazla koşul oluştutulabilinir ve duruma göre koşulu sağlayan skop alanları çalışmış olur 
            // Fakat her ne olursa olsun else yapısı sağlanan koşulların en altında yer alması kodlama için sağlık lı bir durum oluşturur.
            // (else zorunlu değildir)
            if (true)
            {

            }
            else if (true)
            {

            }
            else
            {

            }
            //-----------------------------------------------------------------------------------------------------


            // Örnek Kullanım (Koşul sağlanır)
            if (50 == 50)
            {

            }

            // Koşul sağlanmaz ve else skopları çalışır
            if (50 == 100)
            {

            }
            else
            {

            }

            // ilk koşul sağlanamadığı için 2. koşula bakılır eğer 2. koşul da sağlanamasaydı else kısmına geçiş yapılacaktı.
            if (50 != 50)
            {
                MessageBox.Show("0");
            }
            else if (10 == 10)
            {
                MessageBox.Show("1");
            }
            else
            {

            }

            // Örnek not kontrol karar yapısı 100 lük not sistemi üzerinden şu şekilde yaılır
            int notunuz = 50; // Öğrenci notu 50 dir.
            string cikti = null; // bir değişken belirlenir içeriği karar yapısına göre doldurulur.
            if (notunuz < 0)
            {
                cikti = "Tanımlanamayan Değer Giriş!";
            }
            else if (notunuz < 50)
            {
                cikti = "1";
            }
            else if (notunuz < 60)
            {
                cikti = "2";
            }
            else if (notunuz < 70)
            {
                cikti = "3";
            }
            else if (notunuz < 85)
            {
                cikti = "4";
            }
            else if (notunuz <= 100)
            {
                cikti = "5";
            }
            else
            {
                cikti = "Tanımlanamayan Değer Giriş!";
            }

        }
    }
}
