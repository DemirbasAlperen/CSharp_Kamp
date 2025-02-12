using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            // Foreach(1;2;3;4)  4 tane parametre alır
            // 1: Değişken türü 
            // 2: Değişken adı
            // 3: In (içinde)
            // 4: Liste, Koleksiyon, Dizi
            // Foreach döngüsü sadece diziler ile değil listeler ile de çalışır.

            // Örnek: string bir dizide foreach kullanmak
            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities)   // buradaki city değişken adını istersek değiştiririz.
            //{
            //    Console.WriteLine(city);
            //}

            // Örnek: integer dizilerde foreach kullanımı
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            // Örnek: sayı dizisinde çift sayıları bulma
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            // Örnek: foreach ile sayıları toplama
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;  // number daki her bir sayı total e eklenecek
            //}

            //Console.WriteLine($"Sayıların Toplamı: {total}");

            // Örnek: Listelerde foreach kullanımı
            //List<int> numbers = new List<int>()   // Listeler ve diziler bir koleksiyon öğesidir
            //{
            //    1, 2, 3, 4, 5, 8
            //};

            //foreach (int i in numbers)     
            //{
            //    Console.WriteLine(i);
            //}

            // Örnek: Bir kelimeyi harflerine ayırma (string girilen değeri char ile parçalama)
            //string word = "Merhaba";

            //foreach (char item in word) // burada değişken türü char olan item isimli değişken oluşturdu ve word içerisinde gezip item içerisine harfleri atacak
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Sınıftaki öğrenci saysını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());    // Kullanıcının gireceği öğrenci sayısı
            Console.WriteLine("------------------------------");

            // Öğrenci isimlerini ve not ortalamalarını sağlayacak diziler
            string[] studentNames = new string[studentCount];    // Kullanıcının gireceği öğrenci sayısına göre isim isteyecek
            double[] studentExamAvg = new double[studentCount];   

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;


                // Her öğrenci için 3 sınav notu girişi

                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;   // öğrencinin her notu totalExamResult a eklenecek. Notların toplamı

                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;

            }

            // Sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("---------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı!");
                }

                Console.WriteLine("---------------------------------");

            }

            #endregion


            Console.Read();
        }
    }
}
