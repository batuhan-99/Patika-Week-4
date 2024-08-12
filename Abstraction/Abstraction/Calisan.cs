using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }
        public abstract void Gorev();
    }
    public class YazilimGelistirici : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} şirketin Yazılım Geliştiricisi, Yazılım geliştiriyorum.");
        }
    }
    public class ProjeYoneticisi : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} şirketin Proje Yöneticisi, Proje yöneticisi olarak çalışıyorum.");
        }
    }
    public class SatisTemsilcisi : Calisan
    {
        
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} şirketin Satış Temsilcisi, Müşteri ilişkilerini yönetiyorum.");
        }
    }
}
