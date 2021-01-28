using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // switch case karar yapısı programın yürütme kontrol akışını değiştirmesine izin vermek için kullanılır. if else ile çalışma mantıkları birbirlerine benzemektedir.
            // if else ile farkları direk değer aldığı için ve ilgili değere göre işlem yaptırıldığı için bir karşılaştırma yapmak mümkün değildir.
            // Artıları Eksileri
            // Artıları = if else den daha hızlı tepki verir
            // Eksileri = bir karşılaştırma yapılamaz ve bağlaçlar kullanılamaz (&&-||)
            int ilKodu; // Veri tipi oluşturuldu
            ilKodu = 1; // Veri tipine değer ataması yapıldı

            switch (ilKodu) // işlenecek veri yapısı teslim edildi
            {

                case 1: // gelen değer kontrol edilir ve eğer 1 e eşit ise işlem yapılır
                    MessageBox.Show("Adana");
                    break; // yapılan işlem sonrası yapıdan diğer değerler kontrol edilmeden çıkılır

                case 2:// gelen değer kontrol edilir ve eğer 1 e eşit ise işlem yapılır
                    Console.WriteLine("Adıyaman");
                    break;// yapılan işlem sonrası yapıdan diğer değerler kontrol edilmeden çıkılır

                case 3:// gelen değer kontrol edilir ve eğer 1 e eşit ise işlem yapılır
                    Console.WriteLine("Afyon");
                    break;// yapılan işlem sonrası yapıdan diğer değerler kontrol edilmeden çıkılır

                default:// Gelen değeri karşılanmadı ise çalışır
                    Console.WriteLine("Malesef bulunamadı! Lütfen değerleri kotrol edin.");
                    break;// yapılan işlem sonrası yapıdan çıkılır
            }
        }
    }
}
