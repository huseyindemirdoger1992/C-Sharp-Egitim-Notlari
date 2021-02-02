using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Diziler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Eleman sayısı 10
        // Max index     9
        string[] arabalar = { "Mercedes", "Opel", "Toyota", "Bentley", "BMW", "Alfa Romeo", "Anadol", "Ford", "Hyundai", "Dodge", "Audi" };
        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //Dizinin eleman sayıısını bilmiyoruz, ancak bizden istenen son elemanı kullaniciya gostermek...
            //arabalar.Length => ilgili dizinin uzunlugunu alabilirsiniz..
            MessageBox.Show(arabalar[arabalar.Length - 1]);

        }
        Random rnd = new Random();
        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Rastgele olarak dizinin bir elemani, formun tepesine yazdırılsın...
            // Butona her tıkladığımda rastgele bir dizi elemanı formun text propertisine yazdırılsın
            int index = rnd.Next(0, arabalar.Length);
            Text = arabalar[index];

        }
        int[] sayilar = { 10, 20, 30, 40, 50 };
        int index = 0, toplam = 0;
        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //Butona her bastigimda, ilk elemandan baslayarak sirasi ile dizinin tum elemanlarini listbox'a ekleyiniz.
            //ancak, eklediginiz her elemani da bir havuzda toplayarak anlik olarak elemanlarin toplamini tepeye yazdiriniz..
            if (index == sayilar.Length)
            {
                MessageBox.Show("Dizinin Son Elemanına Ulaştınız");
                return;
            }
            listBox1.Items.Add(sayilar[index]);
            toplam += sayilar[index];
            this.Text = toplam.ToString();
            index++;

            //Array.Sort()
            // Sort, LastIndexOf, IndexOf, Copy, Clear, Reverse, Resize
        }
    }
}
