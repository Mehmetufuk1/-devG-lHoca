namespace Soru_9_mevsim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9 - Klavyeden girilen mevsime ait ayları ekrana yazan program. (Switch -case)

            Console.WriteLine("Lütfen bir mevsim girin: ");

            string mevsim = Console.ReadLine().ToLower(); // Kullanıcının girdiği mevsimdeki harfleri küçük harfe çeviriyoruz.

            Console.WriteLine("mevsimin ayları:");

            switch (mevsim)
            {
                case "sonbahar":
                    Console.WriteLine("Eylül, Ekim, Kasım");
                    break;
                case "kış":
                    Console.WriteLine("Aralık, Ocak, Şubat");
                    break;
                case "ilkbahar":
                    Console.WriteLine("Mart, Nisan, Mayıs");
                    break;
                case "yaz":
                    Console.WriteLine("Haziran, Temmuz, Ağustos");
                    break;
                default:
                    Console.WriteLine("Geçersiz mevsim girişi!");
                    break;
            }
        }
    }
}