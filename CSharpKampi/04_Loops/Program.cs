using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            //int i;
            //for(i=1;i<=5;i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}
            //---------
            //for(int i=1;i<=20;i++)
            //{
            //    Console.WriteLine(i);
            //}
            //------------
            //for(int i=3;i<=50;i+=3)
            //{
            //    Console.WriteLine(i);
            //}
            //----------------
            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi girin: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for(int i=1;i<=finishValue;i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet!");
            //}
            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for(int i=1;i<=100;i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //---------------------
            //int totalvalue = 0;
            //for(int i=1;i<=10;i++)
            //{
            //    totalvalue += i;
            //}

            //Console.WriteLine(totalvalue);
            //---------------------
            //int totalvalue = 0;
            //for(int i=1;i<20;i++)
            //{
            //    if(i%2==0)
            //    { 
            //        totalvalue+=i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("-----");
            //Console.WriteLine(totalvalue);
            //----------------------------

            //int count = 0;
            //for(int i=1;i<=50;i++)
            //{
            //    if(i%7==0)
            //    { 
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //------------

            //int bacterium = 1;
            //for(int i=1;i<=24;i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i+". Saat sonunda: "+bacterium);
            //}

            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}


            //int i = 1;
            //while(i<=10)
            //{
            //    if(i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while(i<=10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız

            Console.WriteLine("Sayıyı giriniz:");
            int number=int.Parse(Console.ReadLine());

            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;

            Console.WriteLine(ones+"-"+tens+"-"+hundreds);
            sum=ones+tens+hundreds;
            Console.WriteLine(sum);


            #endregion

            Console.Read();
        }
    }
}
