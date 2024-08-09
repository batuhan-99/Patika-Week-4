using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_Kutuphane
{
    public class Kitap //Kitap adlı bir sınıf tanımlandı.Bu sınıf ile kitap ile ilgili nesnelerin özelliklerini ve davranışları tanımlandı
    {
        // Aşağıdaki Property'ler ile sınıfın özelliklerini tanımladım
        public string _ad;
        public string _yazaradi;
        public string _yazarsoyadi;
        public int _sayfasayisi;
        public string _yayinevi;
        public DateTime kayittarihi;
        
        //Aşğıda 2 tane constructor tanımlandı. Bu constructorlar ile nesneye başlangıç değerlerini verebildik.
        public Kitap()
        {
            kayittarihi = DateTime.Now;
            Console.WriteLine($"Kayıt tarihi:{kayittarihi}");
        } 
        public Kitap(string ad, string yazaradi, string yazarsoyadi, int sayfasayisi, string yayinevi)
        {
            _ad = ad;
            _yazaradi = yazaradi;
            _yazarsoyadi = yazarsoyadi;
            _sayfasayisi = sayfasayisi;
            _yayinevi = yayinevi;
            kayittarihi = DateTime.Now;
            Console.WriteLine($"Kitap adı={_ad}, Yazar adı={_yazaradi}, Yazar soyadı={_yazarsoyadi}, Sayfa sayısı={_sayfasayisi}, Yayınevi={_yayinevi}");
            Console.WriteLine($"Kayıt tarihi:{kayittarihi}");
        }
    }
}
