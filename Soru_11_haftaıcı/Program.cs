namespace Soru_11_haftaıcı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Girilen güne göre haftaiçi mi haftasonu mu olduğunu söyleyen program

            Console.WriteLine("Lütfen Günü Giriniz");
            string gun = Console.ReadLine().ToLower();

            switch (gun)
            {
                case "pazartesi":
                    Console.WriteLine("Hafta ici");
                    break;
                case "sali":
                    Console.WriteLine("hafta ici");
                    break;
                case "carsamba":
                    Console.WriteLine("hafta ici");
                    break;
                case "persembe":
                    Console.WriteLine("Hafta ici");
                    break;
                case "cuma":
                    Console.WriteLine("hafta ici");
                    break;
                case "cumartesi":
                    Console.WriteLine("hafta sonu");
                    break;
                case "pazar":
                    Console.WriteLine("hafta sonu");
                    break;
                default:
                    Console.WriteLine("Yanlış Giriş Yaptınız");
                    break;
            }

            }
        }
}