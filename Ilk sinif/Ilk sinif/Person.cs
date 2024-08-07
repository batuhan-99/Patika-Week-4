using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilk_sinif
{
    public class Person
    {
        public string ad;
        public string soyad;
        public string dogumtarihi;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad;}
            set { soyad = value; }
        }
        public string Dogumtarihi
        {
            get { return dogumtarihi; }
            set { dogumtarihi = value; }
        }
        public void OgrenciBilgi()
        {
            Console.WriteLine($"Ogrenci adı={ad}, Soyad = {soyad}, Dogum tarihi = {dogumtarihi}");
        }
        public void OgretmenBilgi()
        {
            Console.WriteLine($"Ogretmen adı={ad}, Soyad = {soyad}, Dogum tarihi = {dogumtarihi}");
        }
    }
}
