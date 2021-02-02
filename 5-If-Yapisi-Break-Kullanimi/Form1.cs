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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) // Döngü başlatılır
            {
                if (i == 5) // Karar yapısı oluşturulur
                {
                    break; // Bulunduğun döngüyü bitirip işleyişi dışarı atar.
                }
            }
        }
    }
}
