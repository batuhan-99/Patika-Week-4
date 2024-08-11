using Polymorphism;
using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare(5,6);
            Dikdortgen dikdortgen = new Dikdortgen( 9,9);
            DikUcgen dikucgen = new DikUcgen(8, 4);
            
            Console.WriteLine($"Kare alanı: {kare.AlanHesapla()}");
            Console.WriteLine($"Dikdörtgen alanı: {dikdortgen.AlanHesapla()}");
            Console.WriteLine($"Dik Üçgen alanı: {dikucgen.AlanHesapla()}");
        }
    }
}