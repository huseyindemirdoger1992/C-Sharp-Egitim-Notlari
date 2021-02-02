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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        /*
    FOREACH
    1) Kesinlikle index mantigi yoktur!
    2) Tip bagimli dongulerdir...
    3) Cogu zaman elimizdeki bir koleksiyonun her bir elemanini tek tek ele almak icin kullanilir...
*/

        string[] sehirler = { "Ankara", "Edirne", "İstanbul", "Eskişehir", "Bursa", "Trabzon", "Sivas", "Malatya" };
        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sehirler.Length; i++)
            {
                listBox1.Items.Add(sehirler[i]);
            }

            //string sehir = ""; 
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    sehir = sehirler[i];
            //    listBox2.Items.Add(sehir);
            //}

            foreach (string sehir in sehirler)
            {
                listBox2.Items.Add(sehir);
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //İkiye bolunenleri listbox1'e bolunemeyenleri listbox2 ye atın... Hem ikiye hem uce bolunenlerin kac tane oldugunu da messagebox'la gosterin...
            int[] dizi = { 123, 54, 76, 876, 4532, 23, 77, 734, 83, 45, 190 };
            int toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0 && dizi[i] % 3 == 0)
                    toplam++;
                if (dizi[i] % 2 == 0)
                    listBox1.Items.Add(dizi[i]);
                else
                    listBox2.Items.Add(dizi[i]);
            }
            MessageBox.Show("Dizi İçerisinde Toplamda 3'e ve 2'ye bölünen eleman sayısı : " + toplam);


            listBox1.Items.Clear();
            listBox2.Items.Clear();
            toplam = 0;
            foreach (int sayi in dizi)
            {
                if (sayi % 2 == 0 && sayi % 3 == 0)
                    toplam++;
                if (sayi % 2 == 0)
                    listBox1.Items.Add(sayi);
                else
                    listBox2.Items.Add(sayi);
            }
            MessageBox.Show("Dizi İçerisinde Toplamda 3'e ve 2'ye bölünen eleman sayısı : " + toplam);
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            // listbox1 içerisinde yer alan elemanları, listbox2 içerisine ekleyiniz. birden fazla eleman seçebiliriz. listbox2 içerisine eklediğiniz elemanları listbox2'den siliniz.

            // listbox2 içerisinde yer alan elemanları, listbox1 içerisine ekleyiniz. birden fazla eleman seçebiliriz. listbox1 içerisine eklediğiniz elemanları listbox2 içerisinden siliniz.

            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            // for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            // {
            //     listBox2.Items.Add(listBox1.SelectedItems[i]);
            // }


            //for (int i = 0; i < listBox2.Items.Count; i++)
            //{
            //    listBox1.Items.Remove(listBox2.Items[i]);
            //}

            foreach (var item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }

            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Remove(item);
            }

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(item);
            }
            foreach (var item in listBox1.Items)
            {
                listBox2.Items.Remove(item);
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            // form üzerinde yer alan butonların arkaplan renklerini ve yazı renklerini değiştiriniz.

            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.Tomato;
                    item.ForeColor = Color.White;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] yeni = new string[5];
            Array.Copy(sehirler, 3, yeni, 0, 5);


            var cls = sehirler
                .Skip(3) // ilk 3 elemanı es geç
                .Take(5); // ondan sonra yer alan 5 elemanı teslim al
        }

    }
}
