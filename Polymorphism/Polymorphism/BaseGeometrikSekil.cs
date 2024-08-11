using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class BaseGeometrikSekil
    {
        public int genislik {  get; set; }
        public int yukseklik { get; set; }

        public BaseGeometrikSekil(int Genislik, int Yukseklik)
        {
            genislik = Genislik;
            yukseklik = Yukseklik;
        }
        public virtual int AlanHesapla()
        {
            return genislik * yukseklik;
        }

    }
    public class Kare : BaseGeometrikSekil
    {
        public Kare(int genislik, int yukseklik) : base(genislik, yukseklik)
        {
        }
        public override int AlanHesapla()
        {
             return base.AlanHesapla();
        }
    }
    public class Dikdortgen : BaseGeometrikSekil
    {
        public Dikdortgen(int genislik, int yukseklik) : base(genislik, yukseklik)
        {
        }
        public override int AlanHesapla()
        {
            return base.AlanHesapla();
        }
    }
    public class DikUcgen : BaseGeometrikSekil
    {
        public DikUcgen(int genislik, int yukseklik) : base(genislik, yukseklik)
        {
        }
        public override int AlanHesapla()
        {
            return base.AlanHesapla()/2;
        }
    }
}
