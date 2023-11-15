namespace Soru_7_ternary_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği sayıyı 10'dan küçük olup olmadığını kontrol eden 
            // kodlarıTERNARYoperatörü ile yapınız
            int sayi;
            int sayi1 = 10;
            Console.WriteLine("Lütfen Sayı Giriniz ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi < sayi1 ? "Girdiğiniz Sayı 10 dan küçüktür" : "Sayı 10 dan büyüktür ");
            Console.WriteLine(sayi == sayi1 ? "Girdiğiniz Sayı 10 a eşittir" : "");

        }
    }
}