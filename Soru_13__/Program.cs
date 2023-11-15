namespace Soru_13__
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Kullanıcıdan alınan iki tam sayıdan herhangi birisi negatif ise toplamlarını , ikiside negatif ise çarpımlarını,ikiside pozitif ise aritmetik ortalamalarını bulup ekrana yazdırın(sıfır girilirse hangi sayı 0 girildiyse o sayıyı tekrar alsın.

        a: Console.WriteLine("Lütfen 1. sayıyı gir");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
        b: Console.WriteLine("Lütfen 2. Sayıyı gir");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 < 0 && sayi2 < 0)
            {
                Console.WriteLine("Sayıların ikisi de negatif çarpım: " + (sayi1) * (sayi2));

            }
            else if (sayi1 < 0 || sayi2 < 0)
            {
                Console.WriteLine("Sayılardan Birisi Negatif Toplam: " + (sayi1 + sayi2)); //Sayılardan birisini pozitif algılıyor.

            }
            else if (sayi1 > 0 && sayi2 > 0)
            {
                Console.WriteLine("ikisi de pozitiftir Ortalama: " + (sayi1 + sayi2) / 2);
            }
            else if (sayi1 == 0)
            {
                Console.WriteLine("ilk Sayıyı Sıfır Girdiniz: ");
                goto a;
            }
            else if (sayi2 == 0)
            {
                Console.WriteLine("2. Sayıyı Sıfır Girdiniz");
                goto b;
            }
            else
            {
                Console.WriteLine("Hatalı Giriş");
                goto a;

            }
        }
    }
}