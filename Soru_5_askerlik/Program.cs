namespace Soru_5_askerlik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcıdan cinsiyet(e/k), askerlik durumu(yaptı mı? e/h) ve yaş bilgileri istendikten 
            // sonra,sadece erkek(e), askerliğini yapmış ve de 30 ve daha küçük yaştaki kişilerin
            //başvurusunun kabul edildiği programı if-else komutu ile yazınız

            Console.WriteLine("Lütfen Cinsiyetinizi Giriniz");
            char cinsiyet = Convert.ToChar(Console.ReadLine().ToUpper());
            if (cinsiyet == 'E')
            {
                

                Console.WriteLine("Lütfen Askerlik Durumunuzu Giriniz");
                char askerlik = Convert.ToChar(Console.ReadLine().ToUpper());
                Console.WriteLine("Lütfen Yaşınızı Giriniz");
                int yas = Convert.ToInt32(Console.ReadLine());

                if (cinsiyet == 'E' && askerlik == 'E' && yas <= 30)
                {
                    Console.WriteLine("Başvurunuz Kabul Edilmiştir.");
                }
                else
                {
                    Console.WriteLine("Başvurunuz Kabul Edilmemiştir");
                }
               
            }
            else if (cinsiyet == 'K')
            {
                Console.WriteLine("Başvurunuz Kabul Edilmemiştir.");
            }
            else {
                Console.WriteLine("Hatalı Girdiniz");

            }
        }
    }
}