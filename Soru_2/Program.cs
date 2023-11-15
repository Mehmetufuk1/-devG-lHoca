namespace Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 - Seçilen geometrik şekilegöre alanını ve çevresini hesaplayıp ekrana yazdıran
            //programıyazınız.(Switch - Case kullanılacak.Kare, dikdörtgen, dik üçgen vb.daha fazla
            //geometrik şekilekleyebilirsiniz.Seçtikten sonra kullanıcıdan gereken bilgiler istenip
            //hesap yaptırılabilr.)

            int kenar, alank, cevrek, alanc, cevreu;
        a: Console.WriteLine("Lütfen Hesaplayacağınız şekli giriniz Kare için k üçgen için u");
            char sekil = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Lütfen yapmak işlemi seçiniz Alan için a, çevre için c");
            char islem = Convert.ToChar(Console.ReadLine());


            if (sekil == 'K' || sekil == 'k')
            {
                if (islem == 'a' || islem == 'A')
                {
                    Console.WriteLine("Lütfen kenar uzunluğu giriniz");
                    kenar = Convert.ToInt32(Console.ReadLine());
                    alank = kenar * kenar;
                    Console.WriteLine("Karenin Alanı: " + (kenar * kenar));
                }
                else if (islem == 'c' || islem == 'C')
                {
                    Console.WriteLine("Lütfen kenarı giriniz.");
                    kenar = Convert.ToInt32(Console.ReadLine());
                    cevrek = kenar * 4;
                    Console.WriteLine("Karenin Çevresi: " + cevrek);



                }
                else
                {
                    Console.WriteLine("Hatalı giriş Yaptınız");
                    goto a;

                }
            }
            else if (sekil == 'u' || sekil == 'U')
            {
                if (islem == 'a' || islem == 'A')
                {
                    Console.WriteLine("Lütfen birinci kenar uzunluğu giriniz.");
                    int birincikenar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lütfen dik kenarı giriniz");
                    int dikKenar = Convert.ToInt32(Console.ReadLine());
                    alanc = (birincikenar * dikKenar) / 2;
                    Console.WriteLine("Üçgenin Alanı: " + alanc);



                }
                else if (islem == 'c' || islem == 'C')
                {
                    Console.WriteLine("Lütfen birinci kenar uzunluğu giriniz.");
                    int birincikenar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lütfen dik kenarı giriniz");
                    int dikKenar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lütfen üçüncü kenarı giriniz");
                    int ucuncukenar = Convert.ToInt32(Console.ReadLine());
                    cevreu = (birincikenar + dikKenar + ucuncukenar);
                    Console.WriteLine("Üçgenin Alanı: " + cevreu);
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                    goto a;
                }
               
            }
        }
    }
}