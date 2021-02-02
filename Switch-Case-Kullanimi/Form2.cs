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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /*
* SWITCH - CASE
* IF-Else mantigiyle calisan bir kontrol mekanizmasidir. Aradaki fark, if-else yapisi buyukluk-kucukluk gibi durumlari kontrol ederken,
* switch-case yalnizca esitlik durumlarini kontrol edebilen karar yapimizdir.. Kendisine ait bir index mekanizmasi ile kosullari algilar, 
* siraya koyar ve otomatik olarak yuzlerce kosulunuz olsa bile herbirine bakmadan hangisine uydugunu bulabilir. Bu da performansı direktman etkiler...
* Switch blogu icerisine yazdiginiz veri tipiniz ne ise, case (durum) olarak belirttiginiz tum veriler de ayni veri tipinde olmalıdır!
* break => Kosul saglandi, artik karar yapisindan kendini disari atabilirsin mesajini sisteme verir...
*/

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            // Dışarıdan mevsim adı girilsin, aylar dönsün
            switch (txtGelenDeger1.Text.ToLower())
            {
                case "kış":
                    MessageBox.Show("Aralık - Ocak - Şubat");
                    break;
                case "ilkbahar":
                    MessageBox.Show("Mart - Nisan - Mayıs");
                    break;
                case "yaz":
                    MessageBox.Show("Haziran - Temmuz - Ağustos");
                    break;
                case "sonbahar":
                    MessageBox.Show("Eylül - Ekim - Kasım");
                    break;
                default:
                    // Kullanıcı yukarıda yer alan durumlar haricinde bir değer girer ise bu alan çalışacaktır
                    MessageBox.Show("Geçersiz Parametre");
                    break;
            }


            // kodları düzenlemek için Ctrl + K + D
            if (txtGelenDeger1.Text == "kış")
            {
                MessageBox.Show("Aralık - Ocak - Şubat");
            }
            else if (txtGelenDeger1.Text == "ilkbahar")
            {
                MessageBox.Show("Mart - Nisan - Mayıs");
            }
            else if (txtGelenDeger1.Text == "yaz")
            {
                MessageBox.Show("Haziran - Temmuz - Ağustos");
            }
            else if (txtGelenDeger1.Text == "sonbahar")
            {
                MessageBox.Show("Eylül - Ekim - Kasım");
            }
            else
            {
                MessageBox.Show("Geçersiz Parametre");
            }

        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Eger ilk textbox'a "Admin","Moderator","Yonetici","CEO","Baskan" degerleri girilirse "Yönetim Paneline Yönlendiriliyorsunuz..."
            //"Uye" girilirse "Ana Sayfaya Yonlendiriliyorsunuz...";
            //Harici bir durumda "Bu Sayfayı Görme Yetkiniz Yok!";

        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //İç içe switch kullanarak kullanıcı adını ve şifresini kontrol ediniz.eğer kullanıcı kullanıcıadını ve şifresini doğru girerse "Tebrikler, hem kullanıcı adı hemde şifreniz doğru" uyarısı
            //Kullanıcı adı doğru şifre yanlışsa "Kullanıcı adınız doğru ancak şifreniz yanlış!" uyarısı
            //kullanıcı adı yanlışsa "Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!" uyarusını kullanıcıya veriniz.

        }
    }
}
