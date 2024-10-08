using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //for(x;y;z)

            //int i;
            //for (i = 1; i <=5; i++)
            //{
            //    Console.WriteLine("C# eğitim kampi");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("lütfen ekrana yazılmasını istediğiniz adedi giriniz :");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region For Döngüsü İle Karar Yapıları

            //1-100 arasında 5'e tam bölünen program
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.Write(totalValue);

            //1-20 arasındaki çift sayıları toplamı

            //int totalValue = 0;

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine(totalValue);


            //1-50 7'ye tam bölünen

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".saat sonunda : " + bacterium);
            //}
            #endregion

            #region While Döngüsü

            // while (sart)

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba dünya");
            //    i++;
            //}

            // 1-10 3'e tam bölünen sayılar

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    i++;
            //}

            //1-10 arasındaki sayıların toplamı

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum = sum + i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden Girilen 3 basamaklı sayının basamaklarını toplamını hesaplayan kodu yazınız

            int number;  //567

            Console.WriteLine("bir sayi giriniz :");
            number = int.Parse(Console.ReadLine());

            int ones, tens, hundres;
            int sum = 0;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundres = number / 100;

            Console.WriteLine(ones + "-"+ tens +"-"+ hundres);
            sum = ones + tens + hundres;
            Console.WriteLine(sum);

            



            #endregion

            Console.Read();
        }
    }
}
