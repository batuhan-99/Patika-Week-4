using Ilk_sinif;

public class Program
{
    public static void Main(string[] args)
    {
        Person ogrenci = new Person();
        ogrenci.ad = "Mustafa";
        ogrenci.soyad = "Çınar";
        ogrenci.dogumtarihi = "11.06.1999";
        Person ogretmen = new Person();
        ogretmen.ad = "Eren";
        ogretmen.soyad = "Bozkus";
        ogretmen.dogumtarihi = "12.01.1996";
        ogrenci.OgrenciBilgi();
        ogretmen.OgretmenBilgi();
    }
}
