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

            // 2, 4, 6, 8
            // sarı, kırmızı, mor
            // adana, ankara, istanbul

            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            // Örnek: colors dizi 
            //string[] colors = new string[4];     // 4 elemandan oluşan türü string olan color dizisi
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            // Örnek: cities dizi
            //string[] cities = new string[5];

            //cities[0] = "Milana";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            // Örnek: numbers dizi
            //int[] numbers = new int[10];  // bu arada burada verilen eleman sayısını aşağıda tamamen belirtme zorunluluğu yoktur
            //numbers[0] = 50;           
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            // yukarıda tanımlamadığımız index değerleri 0 dır

            //Console.WriteLine(numbers[7]);

            // Örnek: eleman sayısını belirtmeden dizi tanımlama
            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            // Örnek: colors dizi ve for kullanımı
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)  // burada < kullanma sebebimiz index e göre eleman çağırmasıdır. Yani 7 elemanımız varsa burada i nin 6 ya kadar gitmesi gerekir.
            //{
            //    Console.WriteLine(colors[i]);
            //}

            // Örnek: dizi içinde 3 ile bölünen sayıları ekrana yazdırma
            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine("3 ile tam bölünen sayılar: " + numbers[i]);
            //    } 
            //}

            // Örnek: char ile dizi tanımlama (UNUTMA TEK TIRNAK KULLANILIR)
            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            // Örnek: Dizideki en büyük elemanı bulma
            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];  // önce dizimin ilk elemanını en büyük sayı olarak kabul ettim

            //for (int i = 0; i < myArray.Length; i++)   // dizi içerisinde gezdik
            //{
            //    if (myArray[i] > maxNumber)  // eğer dizimin içindeki değer maxNumber dan büyükse => devamı aşağıda
            //    {
            //        maxNumber = myArray[i];   // maxNumber a büyük olan dizi elemanımı ata
            //    }
            //}

            //Console.WriteLine(maxNumber);

            #endregion

            #region Dizi Metodları

            // Örnek: Dizi uzunluğu => Length
            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            // Örnek: Sayı dizisini küçükten büyüğe sıralama
            //int[] number = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(number);  // diziyi küçükten büyüğe sıralar
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            // Örnek: NOT: Reverse metodu; normalde diziyi tersden sıralar. Fakat büyükten küçüğe sıralama yapacaksak. Önce sort metodu kullanılır, sonra reverse metodu kullanılır.
            //int[] number = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(number);
            //Array.Reverse(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            // Örnek: Dizinin içerisinde bir kullanıcının index numarasını sorgulama
            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            // Örnek: Dizinin en büyük ve en küçük elemanını yazdırma
            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + "\nDizinin En Küçük Elemanı: " + numbers.Min());
            // \n => bu sembol yazının başına konunca o yazıyı bir satır aşağı yazar.

            #endregion

            #region Kullanıcıdan Değer Alma

            // Örnek: Kullanıcıdan şehir isteme ve bu şehirleri ekrana yazdırma
            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");   // i + 1 yazma sebebimiz i nin 0 dan başlaması
            //    cities[i] = Console.ReadLine();    // Kullanıcıdan isteme
            //}
            // Not : console içinde $"{}" bu sembolü kullanmaya alış 
            //Console.WriteLine();
            //Console.WriteLine("----------------------");

            //for (int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. Şehir: {cities[i]} ");
            //}

            // Örnek: Dizi içindeki tüm elemanları toplama
            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];    // sum üzerine i nin her elemanını ekleyecek
            //}

            //Console.WriteLine(sum); 

            // Örnek: dizi içinde tek sayıları ayrı çift sayıları ayrı ayrı listeleme
            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) 
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)      // 2 ye bölümünden kalan 1 ise tek sayıyı verir
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion

            Console.Read();
        }
    }
}
