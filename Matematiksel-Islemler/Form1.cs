using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematiksel_Islemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Matematiksel işlemler 5 adımda toparlanabilir
            /*
            + Toplama İşlemi
            - Çıkarma İşlemi
            * Çarpma İşlemi
            / Bölme İşlemi
            % Mod Alma (Bölmeden kalan değeri temsil eder)
             */

            // + Toplama İşlemi
            int s1, s2, sonuc1; // değişkenler oluşturuldu
            // Değişkenlere değer ataması yapıldı
            s1 = 3;
            s2 = 6;
            // İstenilen işlem yaptırıldı
            sonuc1 = s1 + s2;

            // Dikkat Toplama işlemi metinsel ifadeler ile yapılır ise yan yana yazar.
            // Örneğin
            string ad, soyad,topla;
            ad = "Hüseyin";
            soyad = "DEMİRDÖĞER";
            topla = ad + soyad; // Çıktı= "HüseyinDEMİRDÖĞER"

            // - Çıkarma İşlemi İşlemi
            int s3, s4, sonuc2; // değişkenler oluşturuldu
            // Değişkenlere değer ataması yapıldı
            s3 = 3;
            s4 = 6;
            // İstenilen işlem yaptırıldı
            sonuc2 = s3 - s4;

            // * Çarpma İşlemi İşlemi
            int s5, s6, sonuc3; // değişkenler oluşturuldu
            // Değişkenlere değer ataması yapıldı
            s5 = 3;
            s6 = 6;
            // İstenilen işlem yaptırıldı
            sonuc3 = s3 * s4;

            // / Bölme İşlemi İşlemi
            double s7, s8, sonuc4; // değişkenler oluşturuldu (değer kalanlı olabileceğinden double tipinde veri değişkenleri oluşturuldu)
            // Değişkenlere değer ataması yapıldı
            s7 = 3;
            s8 = 2;
            // İstenilen işlem yaptırıldı
            sonuc4 = s3 / s4;

            // % Mod Alma İşlemi İşlemi
            int s9, s0, sonuc5; // değişkenler oluşturuldu 
            // Değişkenlere değer ataması yapıldı
            s9 = 9;
            s0 = 2;
            // İstenilen işlem yaptırıldı
            sonuc5 = s3 % s4;


        }
    }
}
