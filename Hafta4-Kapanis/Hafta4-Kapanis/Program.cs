using Hafta4_Kapanis;
namespace Hafta4_Kapanis
{
    class Program
    {
        static void Main(string[] args)
        {
            string devamsecimi = "evet";
            int cevap;
            while(devamsecimi == "evet")
            {
                Console.WriteLine("Telefon üretmek için 1 bilgisayar üretmek için 2");
                cevap = Convert.ToInt32(Console.ReadLine());
                if(cevap == 1)
                {
                    Telefon telefon = new Telefon();
                    Console.WriteLine("Telefon adını giriniz:");
                    telefon.ad = Console.ReadLine();
                    Console.WriteLine("Seri numarası giriniz:");
                    telefon.serinumarasi=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Açıklama giriniz:");
                    telefon.aciklama = Console.ReadLine();
                    Console.WriteLine("işletim sistemi giriniz:");
                    telefon.isletimsistemi = Console.ReadLine();
                    Console.WriteLine("Lisansı var mı?");
                    telefon.Lisans = Console.ReadLine();

                    telefon.BilgileriYazdir();
                    telefon.Urunadigetir();
                }
                else if(cevap == 2)
                {
                    Bilgisayar bilgisayar = new Bilgisayar();
                    Console.WriteLine("Bilgisayar adını giriniz:");
                    bilgisayar.ad = Console.ReadLine();
                    Console.WriteLine("Seri numarası giriniz:");
                    bilgisayar.serinumarasi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Açıklama giriniz:");
                    bilgisayar.aciklama = Console.ReadLine();
                    Console.WriteLine("işletim sistemi giriniz:");
                    bilgisayar.isletimsistemi = Console.ReadLine();
                    Console.WriteLine("USB Giriş Sayısını Giriniz (2 veya 4):");
                    bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());
                    Console.WriteLine("Bluetooth var mı? (Evet/Hayır)");
                    string bluetoothCevap = Console.ReadLine().ToLower();
                    bilgisayar.Bluetooth = bluetoothCevap == "evet";
                    bilgisayar.BilgileriYazdir() ;
                    bilgisayar.Urunadigetir() ;
                }
                Console.WriteLine("Ürünler başarıyla üretildi başka bir ürün eklemek ister misiniz?");
                devamsecimi = Console.ReadLine();
                
            }
        }
    }
}