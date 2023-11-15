namespace Soru_10_Trafik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trafik ışıklarının renklerine göre ne yapılacağını söyleyenprogram(switch)

            Console.WriteLine("Lütfen Bir Renk giriniz");

            string renk = Console.ReadLine().ToLower();


            switch (renk)
            {
                case "kirmizi":
                    Console.WriteLine("Lütfen Durunuz.");
                    break;
                case "sari":
                    Console.WriteLine("Lütfen Yavaşlayınız");
                    break;
                case "yesil":
                    Console.WriteLine("Geçebilirsiniz");
                    break;
                default:
                    Console.WriteLine("Yanlış Renk Girdiniz");
                    break;
        }   }
    }
}