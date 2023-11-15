namespace Soru_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen iki sayı için 4 işlem programını yapınız.(iki sayı girilecek seçim +,-, / , * 
            // olacak.Sadece Switch-Case kullanılacak.)

            double sayi1, sayi2;
            Console.WriteLine("Basit Bir C# hesap makinesi");   
            Console.WriteLine("Birinci Sayıyı giriniz");
            sayi1 = double.Parse(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz");
            sayi2 = double.Parse(Console.ReadLine());
            Console.WriteLine("işlem seçiniz [+],[-],[/],[*]");
            string islem = (Console.ReadLine());

            if (sayi2!=0)

            {

                switch (islem)
                {
                    case "+":
                        Console.WriteLine("Toplama" + (sayi1 + sayi2)); 
                        break;
                    case "-":
                        Console.WriteLine("çıkarma: " + (sayi1 - sayi2));
                        break;
                    case "/":
                        Console.WriteLine("Bölme İşlemi: " + (sayi1 / sayi2)); //0 a bölünme sorusu
                        break;
                    case "*":
                        Console.WriteLine("Çarpma İşlemi " + (sayi1 * sayi2));
                        break;
                    default:
                        Console.WriteLine("işlem yapılamadı");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Hatalı Giriş yaptınız bir sayı '0' a bölünemez. ");
            }

        }
    }
}