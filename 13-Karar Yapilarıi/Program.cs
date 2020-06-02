using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Karar_Yapilarıi
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# programlama dilinde, kod akışı yukardan aşağıya doğru hiç bir satır atlanmaksızın devam eder. Ama programcıların bazı durumlarda kod akışına yön vermesi gerekebilir. İşte bu tür durumlarda kod akışına yön vermek için kullanacağımız yapılara "Karar Yapıları" denir.

            //Dışarıdan alınan sayının 1'den büyük olup olmama durumu.

            //int sayi;
            //Console.WriteLine("Lütfen sayı giriniz:");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 1)
            //{
            //    Console.WriteLine("sayı 1'den büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("sayı 1'den küçüktür");
            //}

            //Console.Read();

            //kırmızı ışıkta bekleyen bir aracın durumunu if kontrolü ile gösterelim.

            //string light;
            //Console.WriteLine("Lütfen kırmızı, sarı ya da yeşil renklerinden birini giriniz:");
            //light = Console.ReadLine();

            //if (light == "kırmızı")
            //{
            //    Console.WriteLine("Kırmızı ışık yanıyor. Lütfen bekleyin!");
            //}
            //else if(light=="sarı")
            //{
            //    Console.WriteLine("Sarı ışık yanıyor. Hareket etmek için hazırlanın...");
            //}
            //else if (light == "yeşil")
            //{
            //    Console.WriteLine("Yeşil ışık yanıyor. Geçebilirsiniz...");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış bir değer girdiniz!");
            //}

            //Console.Read();

            //Ternary If

            //Tek satır üzerinde yazılan if kontrlüdür.

            int sayi = 10;
            string deger;
            deger = (sayi > 1) ? "sayı 1'den büyüktür." : "sayı 1'den küçüktür.";
            Console.WriteLine(deger);
            Console.Read();

        }
    }
}
