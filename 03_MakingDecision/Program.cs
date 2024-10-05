using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.WriteLine("Lütfen şifreyi giriniz :");
            //string password;
            //password = Console.ReadLine();


            //if (password == "ABCD")
            //{
            //    Console.WriteLine("passwordunuz dogru");
            //}
            //else
            //{
            //    Console.Write("Sifreniz Hatalı");
            //}


            //Kullanıcıdan Başkent ve ilçe alınan program

            //string capital, country;

            //Console.Write("Bir Ülke giriniz :");
            //country = Console.ReadLine();

            //Console.Write("Bir başkent giriniz : ");
            //capital = Console.ReadLine();

            //if(capital=="ankara" && country == "Türkiye")
            //{
            //    Console.Write("bilgiler dogru");
            //}
            //else
            //{
            //    Console.Write("bilgiler hatali");
            //}

            //int number;
            //Console.WriteLine("Bir sayi giriniz : "); 
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("sayi dogru");
            //}
            //else
            //{
            //    Console.WriteLine("sayi hatali");
            //}

            //int exam1, exam2, exam3;
            //float ort;


            //Console.Write("1.sınav notunuz :");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sınav notunuz :");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3.sınav notunuz :");
            //exam3 = int.Parse(Console.ReadLine());

            //ort = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("ortalamanız : " + ort);

            //if (ort > 0 & ort < 50)
            //{
            //    Console.WriteLine("Basarisiz");
            //}
            //else if (ort > 51 & ort < 69)
            //{
            //    Console.WriteLine("ortalama");
            //}
            //else if (ort > 70 & ort < 84)
            //{
            //    Console.WriteLine("pek iyi");
            //}
            //else
            //{
            //    Console.WriteLine("çok iyi");
            //}

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız : ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "kocaeli" | city=="bursa" | city=="trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //string username;
            //Console.WriteLine("Lütfen kullanıcı adını giriniz :");
            //username = Console.ReadLine();

            //if(username != "admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("hosgeldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("1.Sayiyi giriniz :");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayiyi giriniz :");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write(result);

            //bir sayının tek mi cift oldugu 

            //Console.WriteLine("1.sayiyi giriniz :");
            //int number = int.Parse(Console.ReadLine());


            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayi cifttir");
            //}
            //else
            //{
            //    Console.Write("sayi tektir");
            //}

            #endregion

            #region Char Degişkenler ile Karar Yapıları
            //char team;

            //Console.Write("Lütfen takım sembolünü giriniz : ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if(team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            #endregion

            #region Örnek Proje İle Karar Yapıları

            //Console.WriteLine("****** C# eğitim kampı restoran ******** ");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("1- Ana yemekler");
            //Console.WriteLine("2- çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- Tatlılar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("-------------------------");

            //string menüItem;

            //Console.Write("Lütfen Detayını görmek istediginiz menü seciniz :");
            //menüItem = Console.ReadLine();

            //if (menüItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Ana Yemekler----------");
            //    Console.WriteLine();

            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye yemeği");
            //    Console.WriteLine("4- Fırında Tavuk");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //}

            //if (menüItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Çorbalar----------");
            //    Console.WriteLine();

            //    Console.WriteLine("1- Ezogelin");
            //    Console.WriteLine("2- Mercimek");

            //}

            //if (menüItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Pizzalar----------");
            //    Console.WriteLine();

            //    Console.WriteLine("1- Sucuklu Pizza");
            //    Console.WriteLine("2- Kaşarlı Pizza");
            //    Console.WriteLine("3- Karışık Pizza");

            //}

            //if (menüItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Tatlılar----------");
            //    Console.WriteLine();

            //    Console.WriteLine("1- tiramisu");
            //    Console.WriteLine("2- magnolia");
            //    Console.WriteLine("3- Sütlaç");

            //}

            //if (menüItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------İçecekler----------");
            //    Console.WriteLine();

            //    Console.WriteLine("1- Didi");
            //    Console.WriteLine("2- Sade Soda");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("4- Ayran");
            //    Console.WriteLine("5- Meyve Suyu");
            //}


            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girisi yapiniz :");
            //int mounthNumber = int.Parse(Console.ReadLine());

            //switch (mounthNumber)
            //{
            //    case 1: Console.Write("Ocak");break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("mart"); break;
            //    case 4: Console.Write("nisan"); break;
            //    case 5: Console.Write("mayıs"); break;
            //    case 6: Console.Write("haziran"); break;
            //    case 7: Console.Write("temmuz"); break;
            //    case 8: Console.Write("ağustos"); break;
            //    case 9: Console.Write("eylül"); break;
            //    case 10: Console.Write("ekim"); break;
            //    case 11: Console.Write("kasım"); break;
            //    case 12: Console.Write("aralık"); break;
            //    default:Console.Write("hatalı veri girisi"); break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.sayiyi giriniz :");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayiyi giriniz :");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen yapmak istediginiz islemi seciniz : ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam : " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark : " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım : " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölme : " + result);
            //        break;

            //    default:
            //        Console.WriteLine("hatali bir sembol girisi");
            //        break;
            //}


            #endregion

            Console.Read();

        }
    }
}
