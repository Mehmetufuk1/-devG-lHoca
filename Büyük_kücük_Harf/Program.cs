namespace Büyük_kücük_Harf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char harf;
            Console.WriteLine("Lütfen bir harf girin");
            harf = Convert.ToChar(Console.ReadLine());
            if (char.IsUpper(harf))
                Console.WriteLine("Girdiğiniz harf büyük harftir");
            else if (char.IsLower(harf))
                Console.WriteLine("Girdiğiniz harf küçük harftir");
            else
                Console.WriteLine("Yanlış Giriş Yaptınız");

        }
    }
}