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
            #region 1-Void Metotlar

            // () Metotların sonuna konur
            // Metotların üzerine fare ile gelince mor renkli bir küp görünür. Bu durum onun bir metot olduğunu gösterir.

            /* Metotlar 2 ye ayrılır;
            1- Geriye Değer Döndürmeyen Metodlar (void Metodlar)
            Customer --> Listeler, ekle, sil, güncelle
            */

            // Örnek: void kullanımı
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();   // Not; metodları oluşturduktan sonra ekranda görünmesi için buradaki gibi çağırmamız gerekir.
            //CustomerList();   // Not; Metodları birden fazla kez çağırabiliriz
            //CustomerList();   
            //CustomerList();   

            // Örnek: void ile toplama işlemi
            //void Sum()   // Metod isimleri büyük harf ile başlar
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metodlar

            // Örnek: parametreli void kullanımı
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");   // Bu sefer burada method içerisine bir isim(customerName) gireriz.

            // Örnek: parametreli void ile müşteri isim soyisim yazdırma
            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine($"Müşteri: {name} {surName}");
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");


            #endregion

            #region 2-Geriye Değer Döndürmeyen Int Parametreli Metodlar

            // Örnek: void parametreli metod kullanarak sayı toplama
            //void Sum(int number1, int number2, int number3)
            //{
            //    int result  = number1 + number2 + number3;
            //    Console.WriteLine($"Sayıların Toplamı: {result}");
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metodlar

            // Burada artık void kullanılmaz. 
            // Bir değişken türü veya bir sınıf türü ile tanımlanır

            // Örnek: string metod
            //string CustomerName()
            //{
            //    return "Buse Yıldırım";  // geriye değer döndürme işlemi return ile yapılır
            //}

            //CustomerName();

            // Örnek: return dan dönen ifadeyi ekrana yazdırma
            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());  // metod u console içerisine yazarak ekrana yazdırdık 

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metodlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;   // kısa olsun diye bu string ifadeler kullanıldı
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));   // x, y, z nin sırayla countryName, capital, flagColor olduğunu metod içerisinde belirttik.

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));   // Buradaki gibi de değerleri doğrudan metod içerisinde belirtebiliriz.

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metodlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci dersi geçti" + " Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci dersten kaldı" + " Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            Console.WriteLine(ExamResult("Ayşe", 45, 95, 15));
            Console.WriteLine(ExamResult("Emre", 25, 41, 18));

            #endregion

            Console.Read();

        }
    }
}
