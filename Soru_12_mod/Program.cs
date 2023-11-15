namespace Soru_12_mod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Klavyeden girilen iki sayının birbirine tam bölünüp bölünmediğini söyleyen program

            Console.WriteLine("Lğtfen 1. Sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı gir");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi1 % sayi2 == 0 && sayi2!=0 ? "Tam Bölünür." : "Tam Bölünemez");
        }
    }
}