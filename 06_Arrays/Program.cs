using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] color = new string[4];
            //color[0] = "Kırmızı";
            //color[1] = "Sarı";
            //color[2] = "Beyaz";
            //color[3] = "Mavi";

            //Console.WriteLine(color[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 48;
            //numbers[2] = 24;
            //numbers[3] = 78;
            //numbers[7] = 566;

            //Console.WriteLine(numbers[7]);

            //string[] cities = { "Prag", "Atina", "Ankara", "Bursa", "Roma" };
            //Console.WriteLine(cities[2]);
            #endregion

            #region Dizideki Tüm Elemanları Döndürme
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Turuncu", "Pembe", "Yeşil" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //3'e tam bölünen sayıları listeleme
            //int[] numbers = { 1, 2, 84, 675, 488, 527, 2345, 1120, 96 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] sybols = { 'a', 'b', 'd', '/', '!', '-' };
            //for (int i = 0; i < sybols.Length; i++)
            //{
            //    Console.WriteLine(sybols[i]);
            //}

            //Dizideki en büyük sayıyı bulan sayı
            //int[] numbers = { 1, 2, 3, 45, 67, 88, 65, 34 };
            //int enbüyükSayi = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > enbüyükSayi)
            //    {
            //        enbüyükSayi = numbers[i];
            //    }
            //}
            //Console.WriteLine(enbüyükSayi);

            //string[] persons = { "ali", "ahmet", "buse", "yusuf", "yunus", "ayşe" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 2, 45, 65, 67, 23, 89, 55, 23 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 2, 45, 65, 67, 23, 89, 55, 23 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] customers = { "ali", "buse", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 1, 2, 45, 67, 87, 454, 78 };
            //Console.WriteLine("Dizinin en büyük elemanı : " + numbers.Max() + " Dizinin en küçük elemanı : " + numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehrini giriniz :");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 9, 56, 98, 67, 90 };
            //int toplam = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    toplam += numbers[i];
            //}
            //Console.WriteLine(toplam);

            //Dizideki sayıları tek ve cift olarak ayrı ayrı olarak listeleme

            //int[] numbers = { 1, 2, 34, 56, 23, 77, 99, 45 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine("-----------------");
     
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();

            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine("-----------------");
 
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion

            Console.Read();
        }
    }
}
