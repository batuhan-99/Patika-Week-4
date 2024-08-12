using Abstraction;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjeYoneticisi hasan = new ProjeYoneticisi();
            hasan.Ad = "Hasan";
            hasan.Soyad = "Cildirmis";
            hasan.Departman = "Proje Yönetimi";

            hasan.Gorev();

            YazilimGelistirici ali = new YazilimGelistirici();
            ali.Ad = "Ali";
            ali.Soyad = "Yildirim";
            ali.Departman = "Yazılım Geliştirici";

            ali.Gorev();

            SatisTemsilcisi ayse = new SatisTemsilcisi();
            ayse.Ad = "Ayşe";
            ayse.Soyad = "Kaya";
            ayse.Departman = "Satis Temsilcisi";

            ayse.Gorev();



        }
    }
}