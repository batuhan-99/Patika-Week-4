using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class BaseKisi
    {
        public string _ad { get; set; }
        public string _soyad { get; set; }

        public virtual void Bilgi()
        {
            Console.WriteLine($"İsim : {_ad}, Soyisim : {_soyad}");
        }

    }
    public class Ogrenci : BaseKisi
    {
        public int No { get; set; }
        public  override void Bilgi()
        {
            Console.WriteLine($"Ogrenci Numarası : {No}");
            base.Bilgi();
        }
    }
    public class Ogretmen : BaseKisi
    {
        public double maaş {  get; set; }
        public  override void Bilgi()
        {
            Console.WriteLine($"Maaş : {maaş}");
            base.Bilgi();
        }
    } 
}
