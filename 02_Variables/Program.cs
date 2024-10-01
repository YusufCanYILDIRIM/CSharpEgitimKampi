using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Degiskenler

            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, tomatoPrice, potatoPrice;

            //applePrice = 14.84;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //tomatoPrice = 9.74;
            //potatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı :" + applePrice);
            //Console.WriteLine("---- Portakal Birim Fiyatı :" + orangePrice);
            //Console.WriteLine("---- Çilek Birim Fiyatı :" + strawberryPrice);
            //Console.WriteLine("---- Domates Birim Fiyatı :" + tomatoPrice);
            //Console.Write("---- Patates Birim Fiyatı :" + potatoPrice);

            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram, orangeGram, strawberryGram, tomatoGram, potatoGram;

            //appleGram = 1.250;
            //orangeGram = 2.300;
            //strawberryGram = 0.750;
            //tomatoGram = 3.450;
            //potatoGram = 4.500;


            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;
            //double potatoTotalPrice = potatoGram * potatoPrice;

            //Console.WriteLine("Alınan Ürün : Elma - " + "Birim Fiyatı :" + applePrice + " Gramajı :" + appleGram + " Toplam Fiyat : " + appleTotalPrice);  
            //Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyatı :" + orangePrice + " Gramajı :" + orangeGram + " Toplam Fiyat : " + orangeTotalPrice);  
            //Console.WriteLine("Alınan Ürün : Çilek - " + "Birim Fiyatı :" + strawberryPrice + " Gramajı :" + strawberryGram + " Toplam Fiyat : " + strawberryTotalPrice);  
            //Console.WriteLine("Alınan Ürün : Domates - " + "Birim Fiyatı :" + tomatoPrice + " Gramajı :" + tomatoGram + " Toplam Fiyat : " + tomatoTotalPrice);  
            //Console.WriteLine("Alınan Ürün : Patates - " + "Birim Fiyatı :" + potatoPrice + " Gramajı :" + potatoGram + " Toplam Fiyat : " + potatoTotalPrice);  


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine("Toplam Tutar :" + shoppingTotalPrice);

            #endregion

            #region Char Değiskenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region  Klavyeden Veri Girisleri String Degiskenler

            //Console.WriteLine("***** CSharp Hava Yolları Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Adınız : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Soyadınız : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("semt : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("sehir : ");
            //passengerCity = Console.ReadLine();

            //Console.Write("yasiniz :");
            //passengerAge = Console.ReadLine();

            //Console.Write("T.C. kimlik numara : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("------------------");
            //Console.WriteLine("Yolcu Bilgileri : " + passengerName +  " " + passengerSurname + " " + passengerDistrict +  " " + passengerCity + " " + passengerAge + " " + passengerIdentityNumber);
            #endregion

            #region Klavyeden Tam Sayılar Ve Dönüsümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldıgınız ayakkabi adedini giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldıgınız bilgisayar adedini giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldiginiz sandalye adedini giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldiginiz tv adedini giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int shoesTotalPrice, computerTotalPrice, chairTotalPrice, tvTotalPrice;

            //shoesTotalPrice = shoesPrice * shoesCount;
            //computerTotalPrice = computerPrice * computerCount;
            //chairTotalPrice = chairPrice * chairCount;
            //tvTotalPrice = tvPrice * tvCount;

            //int articleTotalPrice;
            //articleTotalPrice = shoesTotalPrice + computerTotalPrice + chairTotalPrice + tvTotalPrice;

            //Console.WriteLine();

            //Console.WriteLine("Ayakkabı : " + "Birim Fiyatı :" + shoesPrice + " / Toplam ücret : " + shoesTotalPrice);
            //Console.WriteLine("Bilgisayar : " + "Birim Fiyatı :" + computerPrice + " / Toplam ücret : " + computerTotalPrice);
            //Console.WriteLine("Sandalye : " + "Birim Fiyatı :" + chairPrice + " / Toplam ücret : " + chairTotalPrice);
            //Console.WriteLine("TV : " + "Birim Fiyatı :" + tvPrice + " / Toplam ücret : " + tvTotalPrice);

            //Console.WriteLine();
            //Console.WriteLine("Ürünler Toplami : " + articleTotalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İslemleri

            //kalvyeden ögrenci notları girme

            //double exam1, exam2, exam3, result;

            //Console.Write("1.Notu Giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2.Notu Giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3.Notu Giriniz :");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Sonucunuz : " + result);

            #endregion

            #region Klavyden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seciniz : ");
            //gender =char.Parse(Console.ReadLine());

            //Console.WriteLine("Sectiginiz cinsiyet : " + gender);   

            #endregion

            Console.Read();
        }
    }
}
