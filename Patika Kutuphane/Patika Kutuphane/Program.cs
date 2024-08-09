using Patika_Kutuphane;

namespace Patika_Kutuphane
{
    class Program
    {
        static void Main(string[] args)
        {
            //new anahtar kelimesi ile kitap sınıfından yeni bir nesne oluşturdum
            Kitap kitap1 = new Kitap("Bir Kitap", "Ahmet", "Yılmaz", 320, "Alfa Yayınları");
            Kitap kitap2 = new Kitap("Başka Bir Kitap", "Ayşe", "Karan", 215, "Beta Yayıncılık");
            Kitap kitap3 = new Kitap("Daha Başka Kitap", "Mehmet", "Demir", 450, "Gamma Yayınları");
            Kitap kitap4 = new Kitap("Son Kitap", "Elif", "Şahin", 275, "Delta Yayıncılık");
            Kitap kitap5 = new Kitap("Örnek Kitap", "Selin", "Yurt", 198, "Epsilon Yayınları");

            Kitap kitap6 = new Kitap();
            Kitap kitap7 = new Kitap();
            Kitap kitap8 = new Kitap();
            Kitap kitap9 = new Kitap();
            Kitap kitap10 = new Kitap();

        }
    }
}