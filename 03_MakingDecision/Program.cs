﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
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

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış!");
            //}


            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi!");
            //}


            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number= int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış!");
            //}

            //int exam1, exam2, exam3, avarage;
            //string result= "HATA!";

            //Console.Write("Sınav 1 sonucu:");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2 sonucu:");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3 sonucu:");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1+exam2+exam3)/3;
            //Console.WriteLine("Ortalama: "+ avarage);

            //if (avarage > 0 & avarage <= 50) 
            //{
            //    result = "Öğrenci Başarısız";       
            //}

            //if (avarage > 50 & avarage <= 70)
            //{
            //    result="Ortalam Öğrenci"; 
            //}

            //if(avarage >70 & avarage <= 84)
            //{
            //    result= "İyi Öğrenci";
            //}
            //if (85<= avarage) 
            //{
            //    result = "Başarılı Öğrenci";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //string username;

            //Console.Write("Lütfen kullamıcı adını giriniz: ");
            //username= Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}

            #endregion


            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number %5;
            //Console.WriteLine(result);

            //int number1, number2, result;

            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //number1 =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //result = number1 % number2;
            //Console.WriteLine("1.Sayının 2.Sayıya Bölümünden kalan: " +result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}







            #endregion


            #region Char Değişkenler ile Karar yapıalrı
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if (team=='B'| team=='b')
            //{
            //    Console.WriteLine("Beşiktaş");

            //}
            //if (team == 'F' | team == 'f') 
            //{
            //    Console.WriteLine("Fenerbahçe");

            //}
            //if (team == 'G' | team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");

            //}

            #endregion

            #region Örnek Proje Uygulamaası

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1-Ana Yemekler ");
            //Console.WriteLine("2-Çorbalar ");
            //Console.WriteLine("3-Pizzalar ");
            //Console.WriteLine("4-İçecekler ");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();


            //string menuItem;
            //Console.Write("Bir Başlık Seçiniz:");
            //menuItem = Console.ReadLine();

            //if (menuItem =="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabbağı");
            //    Console.WriteLine("3-Fasülye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası ");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Su");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç ");;
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");

            //}

            #endregion

            #region Switch Case
            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int mountNumber=int.Parse(Console.ReadLine());
            //switch (mountNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi");break;

            //}




            #endregion

            #region Switvh Case Hesap Makinesi

            //int number1, number2,result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğinizişlemi giriniz: ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.Write("Toplma: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.Write("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.Write("Çapım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.Write("Bölüm: " + result);
            //        break;
            //}


            #endregion


            Console.ReadLine();
        }
    }
}
