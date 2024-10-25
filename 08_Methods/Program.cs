using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar 

            //() 
            //Geriye Değer Döndürmeyen Metotlar
            //Custemer --> Listele,ekle, sil,güncelle
            //Void

            //void CustumerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustumerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}
            //Sum();




            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);

            //}
            //WriteMethod("Mehmet Yıldırım");


            //void CustemerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: "+name+" "+surname);


            //}
            //CustemerCard("Mehmet","Yıldız");
            //CustemerCard("Ayşegül", "Yıldız");


            #endregion

            #region  Geriye Değer Döndürmeyen INT Parametreli Metotlar

            //void sum(int number1, int number2 , int number3)
            //{
            //    int result = number1 + number2+ number3;
            //    Console.WriteLine(result);                

            //}
            //sum(4, 5, 6);


            #endregion

            #region Geriye değer döndüren metotlar

            //string custemerName()
            //{
            //    return " Buse Yıldız";
            //}
            //custemerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";

            //    return name + " " + surname;

            //}
            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar 

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " Başkent: " + capital + " Bayrak rengi: " + flagColor;
            //    return cardInfo;

            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkent Adını Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı- Beyaz"));
            #endregion

            #region Geriye Değer Döndüren Int  Parametreli Metotlar

            //int sum(int number1, int number2)
            //{
            //    int result =number1 + number2;
            //    return result;  
            //}
            //Console.WriteLine(sum(45, 98));
            //Console.WriteLine(sum(36, 25));
            //Console.WriteLine(sum(44, 36));
            //Console.WriteLine(sum(14, 20));


            #endregion

            #region Örnek

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 +exam2+ exam3) / 3;
                if (result >= 50)
                {
                    return "Öğrenci sınavı geçti";
                    
                }
                else
                {
                    return "Öğrenci başarısız oldu ";
                }
            }
            Console.WriteLine(ExamResult("Ali:",25,41,85));
            Console.WriteLine(ExamResult("Ayşe:", 36, 88, 33));

            #endregion



            Console.Read();

        }
    }
}
