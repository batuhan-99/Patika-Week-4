using Inheritance;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            Ogretmen ogretmen = new Ogretmen();

            ogrenci._ad = "Mustafa";
            ogrenci._soyad = "Çınar";
            ogrenci.No = 47896;
            ogretmen._ad = "Eren";
            ogretmen._soyad = "Bozkurt";
            ogretmen.maaş = 13500;
            ogrenci.Bilgi();
            ogretmen.Bilgi();
        }
    }
}