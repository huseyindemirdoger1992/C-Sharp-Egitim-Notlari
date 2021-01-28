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
    }
}
