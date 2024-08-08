using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Bebek
    {
        public DateTime DogumTarihi;
        public string _Ad;
        public string _Soyad;
        public Bebek()
        {
            Console.WriteLine("Ingaaa");
            DogumTarihi = DateTime.Now;
            Console.WriteLine($"Bebeğin doğum tarihi:{DogumTarihi}");
        }
        public Bebek(string Ad, string Soyad)
        {
            _Ad = Ad;
            _Soyad = Soyad;
            DogumTarihi = DateTime.Now;
            Console.WriteLine("Ingaaa");
            Console.WriteLine($"Bebeğin adı={_Ad}, Soyadı={_Soyad}, Doğum tarihi:{DogumTarihi}");
        }

    }
}
