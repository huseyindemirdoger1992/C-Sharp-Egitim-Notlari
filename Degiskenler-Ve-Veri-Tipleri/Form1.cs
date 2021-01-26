using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Ve_Veri_Tipleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // DEĞİŞKEN OLUŞTURMA KURALLARI 

            /*  
             1-Değişken ismi içerisinde boşluk kullanılmaz.

             Doğru —  Adi_Soyadi

             Yanlış — Adi  Soyadi

             2-Değişken isimleri rakam veya özel karakterler ile başlayamaz.harf ile başlamalıdır.

             Doğru — Sozlu1

             Yanlış — 1.Sozlu

             3-Programlama dilinin kullandığı komut satırları değişken ismi olarak kullanılamaz. ( Özel sözcükler (if, else, random,  vb.) kullanılmaz.)

             Yanlış — int void

             Yanlış — string try

             4-Değişken isminin 255 karakterden fazla olmaması gerekir.

             5-Değişken ismi içerisinde harf,rakam ve alt çizgi dışındaki karakterler kullanılmamalıdır.

             Doğru — Adi_Soyadi

             Yanlış — Adi+Soyadi

            6- Türkçe karakter kullanılmamalıdır. Ş, ğ,ü,ö,ç,ı gibi…

            7- Tanımlama yaparken büyük-küçük harf ayrımı vardır.

            8-  Özel karakter içermez örneğin /,*,-,+.

            */



            // DEĞİŞKEN VE VERİ TİPLERİ

            // sbyte	1 Byte işaretli tamsayı	-128  ile 127
            sbyte ssx; // Değişken tanımlaması yapılıyor
            sbyte sy, sz = 2; // değişken tanımlaması ve değer ataması yapılıyor
            sbyte s1, s2 = 4, s3; // 3 değişken tanımlandı 2 tanesine değer atandı 3. ise daha sonra değer ataması için oluşturuldu
            ssx = 0; // 1. yapıya değer ataması gerçekleştirildi.

            // short	2 Byte işaretli tamsayı	-32.768 ile 32.767
            short bsx; // Değişken tanımlaması yapılıyor
            short bsy, bsz = 2; // değişken tanımlaması ve değer ataması yapılıyor
            short bs1, bs2 = 4, bs3; // 3 değişken tanımlandı 2 tanesine değer atandı 3. ise daha sonra değer ataması için oluşturuldu
            bsx = 0; // 1. yapıya değer ataması gerçekleştirildi.

            // int	4 Byte işaretli tamsayı	-2.147.483.648 ile 2.147.483.647
            int isx; // Değişken tanımlaması yapılıyor
            int isy, isz = 2; // değişken tanımlaması ve değer ataması yapılıyor
            int is1, is2 = 4, is3; // 3 değişken tanımlandı 2 tanesine değer atandı 3. ise daha sonra değer ataması için oluşturuldu
            isx = 0; // 1. yapıya değer ataması gerçekleştirildi.

            // long	8 Byte işaretli tamsayı	-9.223.372.036.854.775.808 ile 9.223.372.036.854.775.807
            long lsx; // Değişken tanımlaması yapılıyor
            long lsy, lsz = 2; // değişken tanımlaması ve değer ataması yapılıyor
            long ls1, ls2 = 4, ls3; // 3 değişken tanımlandı 2 tanesine değer atandı 3. ise daha sonra değer ataması için oluşturuldu
            lsx = 0; // 1. yapıya değer ataması gerçekleştirildi.

            // byte	1 Byte işaretsiz tamsayı	0 ile 255
            byte bysx; // Değişken tanımlaması yapılıyor
            byte bysy, bysz = 2; // değişken tanımlaması ve değer ataması yapılıyor
            byte bys1, bys2 = 4, bys3; // 3 değişken tanımlandı 2 tanesine değer atandı 3. ise daha sonra değer ataması için oluşturuldu
            bysx = 0; // 1. yapıya değer ataması gerçekleştirildi.

            // ushort	2 Byte işaretsiz tamsayı	0 ile 65.535
            ushort ussx; // Değişken tanımlaması yapılıyor
            ushort ussy, ussz = 2; // değişken tanımlaması ve değer ataması yapılıyor
            ushort uss1, uss2 = 4, uss3; // 3 değişken tanımlandı 2 tanesine değer atandı 3. ise daha sonra değer ataması için oluşturuldu
            ussx = 0; // 1. yapıya değer ataması gerçekleştirildi.

            // uint	4 Byte işaretsiz tamsayı	0 ile 4.294.967.295
            uint utsx; // Değişken tanımlaması yapılıyor
            uint utsy, utsz = 2; // değişken tanımlaması ve değer ataması yapılıyor
            uint uts1, uts2 = 4, uts3; // 3 değişken tanımlandı 2 tanesine değer atandı 3. ise daha sonra değer ataması için oluşturuldu
            utsx = 0; // 1. yapıya değer ataması gerçekleştirildi.

            // ulong	8 Byte işaretsiz tamsayı	0 ile 18.446.744.073.709.551.615
            ulong ugsx; // Değişken tanımlaması yapılıyor
            ulong ugsy, ugsz = 2; // değişken tanımlaması ve değer ataması yapılıyor
            ulong ugs1, ugs2 = 4, ugs3; // 3 değişken tanımlandı 2 tanesine değer atandı 3. ise daha sonra değer ataması için oluşturuldu
            ugsx = 0; // 1. yapıya değer ataması gerçekleştirildi.

            // float	4 Byte tek kayan sayı	+yada – 1,5*10-45 : + ya da – 3,4*1038
            float ftsx; // Değişken tanımlaması yapılıyor
            float ftsy, ftsz = 2; // değişken tanımlaması ve değer ataması yapılıyor
            float fts1, fts2 = 4, fts3; // 3 değişken tanımlandı 2 tanesine değer atandı 3. ise daha sonra değer ataması için oluşturuldu
            ftsx = 0; // 1. yapıya değer ataması gerçekleştirildi.

            // double	8 Byte çift kayan sayı	+yada – 5*10-324 : + ya da – 1,7*10308
            double desx; // Değişken tanımlaması yapılıyor
            double desy, desz = 2; // değişken tanımlaması ve değer ataması yapılıyor
            double des1, des2 = 4, des3; // 3 değişken tanımlandı 2 tanesine değer atandı 3. ise daha sonra değer ataması için oluşturuldu
            desx = 0; // 1. yapıya değer ataması gerçekleştirildi.

            // decimal	16 Byte ondalıklı sayı	+yada – 1,5*10-28 : + ya da – 7,9*1028
            decimal dlsx; // Değişken tanımlaması yapılıyor
            decimal dlsy, dlsz = 2; // değişken tanımlaması ve değer ataması yapılıyor
            decimal dls1, dls2 = 4, dls3; // 3 değişken tanımlandı 2 tanesine değer atandı 3. ise daha sonra değer ataması için oluşturuldu
            dlsx = 0; // 1. yapıya değer ataması gerçekleştirildi.

            // char	2 Byte	Unicode karakterler	U + u + ffff 0000 Tek tırnak ile kullanılır
            char cr1; // Değişken tanımlaması yapılıyor
            char cr2, cr3 = 'M'; // değişken tanımlaması ve değer ataması yapılıyor
            char cr4, cr5 = 'Y', cr6; // 3 değişken tanımlandı 2 tanesine değer atandı 3. ise daha sonra değer ataması için oluşturuldu
            cr1 = 'C'; // 1. yapıya değer ataması gerçekleştirildi.

            char harf1 = 'C'; //dogrudan karakter atayabilirsiiz
            char harf2 = '\x0058'; //hexadecimal karakter karsılığını yazabilirsiniz
            char harf3 = (char)55; //ascii sayısal karsılıgından char türüne donusum yapabilirsiniz (veri şifrelemede Kullanacağız.)
            char harf4 = '\u0058';   //Unicode karakter ataması yapabilirsiniz

            // sadece 2 değer alabilir ve true doğru bir işlem sonrasında döner, false ise yanlış ve olumsuz değer anlamına gelir.
            bool Deger1 = true;
            bool Deger2 = false;


            // string	Değişken (Metinsel ifadeler için kullanılır)
            string mesaj = "Merhaba Memleket Yazılım!";


        }
    }
}
