namespace Soru_6_vize_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Girilen vize ve final notlarına göre vize notunun % 40'ı final notunun %60 
                 alınarakhesaplanan toplam not 50yi geçiyorsa öğrencinin dersten geçip geçmediğini
              bulanalgoritmayı yazınız
             */


            Console.WriteLine("Lütfen Vize Notunu Giriniz");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen Final Notunu Giriniz");
            double final = Convert.ToDouble(Console.ReadLine());
            double not = (vize * 0.4) + (final * 0.6);

            if (vize > 0 && vize < 100 && final < 100 && final > 0 && not > 0 && not < 50)
            {
                Console.WriteLine("Notunuz: " + not + " Kaldınız");
            }
            else if (vize > 0 && vize < 100 && final < 100 && final > 0 && not < 100 && not >= 50)
            {
                Console.WriteLine("Notunuz " + not + " Geçtiniz");

            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız");
            }       
         }
    }
}