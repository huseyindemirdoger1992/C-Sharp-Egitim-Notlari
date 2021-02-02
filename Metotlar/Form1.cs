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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Db Kaydet
            Temizle();

        }

        private void Temizle()
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Text = null;
            textBox4.Text = string.Empty;
            textBox5.Text = default(string);
            textBox6.Text = textBox7.Text = textBox8.Text = "";
            textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = textBox16.Text = textBox15.Text = "";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Excel Kaydet
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Xml Kaydet

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
