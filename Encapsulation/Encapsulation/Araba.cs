using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Araba
    {
        private string _marka;
        private string _model;
        private string _renk;
        private int _kapisayisi;

        public Araba(string Marka, string Model, string Renk, int Kapisayisii)
        {
            _marka= Marka;
            _model = Model;
            _renk = Renk;
            Kapisayisi = Kapisayisii; 
        }
        public string Marka
        {
            get
            {
                return _marka;
            }
            set
            {
                _marka = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public string Renk
        {
            get
            {
                return _renk;
            }
            set
            {
                _renk = value;
            }
        }
        public int Kapisayisi
        {
            get 
            { 
                return _kapisayisi;
            } 
            set
            {
                if (value == 2 )
                {
                    _kapisayisi = value;
                    Console.WriteLine($"Kapi sayisi={_kapisayisi}"); 
                }
                else if (value == 4)
                {
                    _kapisayisi = value;
                    Console.WriteLine($"Kapi sayisi={_kapisayisi}");
                }

                else 
                {
                    _kapisayisi = -1;
                    Console.WriteLine("Hatalı kapı sayısı.");
                }
            }
        }
        
        
    }
}
