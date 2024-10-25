using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            //double number;

            //number = 4.85;
            //Console.WriteLine(number);


            //.  bize , olarak dönüyor

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;


            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + "TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + "TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appelGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appelGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appelGram * applePrice;
            //Console.WriteLine("Elmanın Toplam Fiyatı:" + appleTotalPrice);

            //double orangeTotalPrice = orangeGram *orangePrice ;
            //Console.WriteLine("Portakalın Toplam Fiyatı:" + orangeTotalPrice);

            //double strowberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine("Çilek Toplam Fiyatı:" + strowberryTotalPrice);

            //double potatoTotalPrice = potatoGram * potatoPrice;
            //Console.WriteLine("Patatesin Toplam Fiyatı:" + potatoTotalPrice);

            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Domatesin Toplam Fiyatı:" + tomatoTotalPrice);

            //Console.WriteLine();

            //double toplamPrice = appleTotalPrice + orangeTotalPrice + strowberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Toplam Tutar:" + " "+ toplamPrice +" "+ "TL");


            #endregion

            #region Char Değişkenler

            // char değişkenler shıft+2 = ' tanımlanır

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri
            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentityNumber;


            //Console.Write("Yolcu Adı: ");
            //passengerName=Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict=Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();




            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Yolcu Bilgileri:"+ passengerName +" "+ passengerSurname+" "+ passengerDistrict +"/"+ passengerCity+" "+ passengerAge+" "+ passengerIdentityNumber);






            #endregion

            #region Klavyeden Tam Sayı Girişi ve Dönüşümler

            //ASC12D (12 nin sayısasl karşılığı yok)

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount =int.Parse( Console.ReadLine() );

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice= shoesCount*shoesPrice + computerPrice*computerCount + chairPrice*chairCount + tvCount*tvPrice ;


            //Console.WriteLine();
            //Console.WriteLine("Toplam fiyat:" + totalPrice);
            #endregion

            #region Klavyeden Ondalık Sayı işlemleri

            //double exam1 , exam2, exam3, result;

            //Console.Write("Lütefen 1.Sınav Notunu Girin: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütefen 2.Sınav Notunu Girin: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütefen 3.Sınav Notunu Girin: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.Write("Oralama Not Ortalamanız : "+result);






            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender =char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);


            #endregion

            Console.Read();
        }
    }
}
