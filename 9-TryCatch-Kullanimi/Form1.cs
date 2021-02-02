using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_TryCatch_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
               Burada dikkat edilmesi gereken olay şudur
               eğer kodlarım sağlıklı bir şekilde çalışır ise
               "catch" kod bloğum atlanarak işlem görmeyecektir.
           
               eğer try içerisinde bir hata ile karşılaşılır ise de 
               bu sefer try içerisinde ki diğer kod yapıları atlanarak
               "catch" kod bloğu çalıştırılır
            */

            // Çalışacağı öngürülen kod yapıları try içerisinde çalıştırılır.
            try
            {

            }
            // Bir problem olursa devreye girer
            catch (Exception ex) // değişken ile de hata değeri ex değişkenine atanmış olur
            {

                throw; // Kullanıcıya hatayı gösterir
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtGelenDeger.Text);
            MessageBox.Show("Tebrikler Başardın");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(txtGelenDeger.Text);
                MessageBox.Show("Tebrikler Başardın");
            }
            catch
            {
                MessageBox.Show("İşlem Hatası");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(txtGelenDeger.Text);
                MessageBox.Show("Tebrikler Başardın");
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Hatası");
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(txtGelenDeger.Text);
                MessageBox.Show("Tebrikler Başardın");
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Hatası");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Hata alsam da almasam da çalışırım :)");
            }
        }
    }
}
