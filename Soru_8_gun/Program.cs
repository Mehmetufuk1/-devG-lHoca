namespace Soru_8_gun
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Klavyeden girilen sayının hangi güne ait olduğunu bulan program.(switch-case)(1
            //haftaiçin)

            Console.WriteLine("Lütfen bir sayı girin (1-7 arasında):");

            int sayi = Convert.ToInt32(Console.ReadLine());

            string gun;

            switch (sayi)
            {
                case 1:
                    gun = "Pazartesi";
                    break;
                case 2:
                    gun = "Salı";
                    break;
                case 3:
                    gun = "Çarşamba";
                    break;
                case 4:
                    gun = "Perşembe";
                    break;
                case 5:
                    gun = "Cuma";
                    break;
                case 6:
                    gun = "Cumartesi";
                    break;
                case 7:
                    gun = "Pazar";
                    break;
                default:
                    gun = "Lütfen 1 ile 7 arasında bir sayı giriniz.";
                    break;
            }

            Console.WriteLine("Girilen sayı " + gun+ " günüdür.");

        }
    }
}