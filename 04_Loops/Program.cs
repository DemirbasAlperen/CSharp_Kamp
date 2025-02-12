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
            // Döngüler 1+2+3+4+5+6  => program bu tolamayı süreli üzerine ekleyerek yapar. 3+3=6+4=10+5=15+6=21 gibi

            // For Döngüsü:
            // for(x;y;z)
            // x: başlangıç değeri
            // y: bitiş değeri
            // z: artış - azalış değeri

            //int i;

            // ekrana yazı yazdırma
            //for (i = 1; i <= 5; i++)    // for yazıp 2 defa tab tuşuna basarsan taslağı otomatik yazar.
            //{
            //    Console.WriteLine("C# Eğitim Kampı");   // ekrana 5 kere yazar
            //}

            // ekrana sayı yazdırma
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // sayıları 3 er artırarak ekrana yazdırma
            //for (int i = 3; i <= 50; i+=3)    // i+=3 => i üzerine 3 ekleyerek artır
            //{    
            //    Console.WriteLine(i);
            //}

            // ekrana girilen sayı kadar ekrana yazı yazdırma
            //Console.Write("Lütfen ekrana yazılması istediğiniz adedi yazınız: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)         // biz ekranda ne kadar değer girersek ekranda o kaar yazı yazacak
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            // 5 e bölünen satıları ekrana yazdıracak
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);   // 5 e bölünen sayıları ekrana yazdıracak
            //    }
            //}

            // 1 de 10 a kadar sayıları toplama
            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;   // i değerlerini sürekli totalValue üzerine ekleyerek toplar
            //}

            //Console.WriteLine(totalValue);

            // 1 ile 20 arasındaki çift sayıları toplama

            //int totalValue = 0;

            //for (int i = 1; i < 20 ; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);  // 2 ye bölünen sayıları yazar
            //    }        
            //}    

            //Console.WriteLine("-----------");
            //Console.WriteLine("Çift sayıların toplamı: " + totalValue);

            // 1 ile 50 arasında 7 ye tam bölünen kaç tane sayı var bulalım
            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //     if (i % 7 == 0) 
            //     {
            //        count++;        // yukarıdaki döngüde artış miktarına göre sayı her 7 ye bölündüğünde buradaki sayaç 1 artacak 
            //     }
            //} 

            //Console.WriteLine(count);

            // bir bakteri türü var ve her saatte 2 ye bölünüyor. Yani başlangıçta 1 bakteri sonrasında 2 - 4 - 8 - 16 .... ve 24 saatin sonunda burada ne kadar bakteri oluşur?
            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;   // bakteri değeri her saat 2 ile çarpılıp eklenecek 
            //    Console.WriteLine(i + ". Saat Sonunda: " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            // Şart sağlandığı müddetçe döngü sağlanır. kaç kere döneceği belli olmayan, koşulun bir girdiye göre denetlendiği durumlarda kullanılır.
            // while(şart)
            // {
            //     işlemler
            // }

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;  // i sayısı 11 olana kadar devam eder ve 11 olunca döngü biter
            //}


            // 1 ile 10 arasında 3 e tam bölünen sayıları bulalım
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            // 1 ile 10 arasındaki sayıların toplamı
            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            // 456 için

            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundred;   // birler, onlar, yüzler basamakları
            //int sum;

            //ones = number % 10;     //onlar basamağını sayıyı 10 a bölerek bulabiliriz
            //hundred = number / 100;  // yüzler basamağı için sayıyı 100 e bölersem 4.56 gelir ve int kullandığım için küsüratı almaz 4 ü alır
            //tens = (number % 100) / 10;  // onlar basamağı için sayıyı 100 e bölersem 56 gelir ve bunu da 10 a bölersem 5 sayısını elde ederim    

            //Console.WriteLine("Birler basamağı: " + ones + " -Onlar Basamağı: " + tens + " -Yüzler Basamağı: " + hundred);
            
            //sum = ones + tens + hundred;
            //Console.WriteLine("Rakamların Toplamı: " + sum);

            #endregion


            Console.Read();

        }
    }
}
