using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Kapanis
{
    public abstract class BaseMakine
    {
        public DateTime UretimTarihi = DateTime.Now;
        public int serinumarasi { get; set; }
        public string ad {  get; set; }
        public string aciklama { get; set; }
        public string isletimsistemi {  get; set; }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
            Console.WriteLine($"Seri Numarası: {serinumarasi}");
            Console.WriteLine($"Ad: {ad}");
            Console.WriteLine($"Açıklama: {aciklama}");
            Console.WriteLine($"İşletim Sistemi: {isletimsistemi}");
        }
        public abstract void Urunadigetir();
        
    }
    public class Telefon : BaseMakine
    {
        public string Lisans {  get; set; }
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"TR Lisanslı: {Lisans}");
        }
        public override void Urunadigetir()
        {
            Console.WriteLine($"Ad: {ad}");
        }
    }
    public class  Bilgisayar : BaseMakine 
    {
        
        private int usbGirisSayisi;
        public bool Bluetooth { get; set; }
        public int UsbGirisSayisi
        {
            get { return usbGirisSayisi; }
            set
            {
                if (value == 2 || value == 4)
                {
                    usbGirisSayisi = value;
                }
                else
                {
                    Console.WriteLine("Hatalı USB giriş sayısı. 2 veya 4 olmalı. -1 olarak atanacak.");
                    usbGirisSayisi = -1;
                }
            }
        }
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
            Console.WriteLine($"Bluetooth: {Bluetooth}");
        }
        public override void Urunadigetir()
        {
            Console.WriteLine($"Ad: {ad}");
        }

    }
}
