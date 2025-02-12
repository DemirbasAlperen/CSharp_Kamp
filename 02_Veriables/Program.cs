using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Not : Öncelikle projeyi yeni açınca sağ tarafta projeye sağ tıkla ve set as startup(başlangıç olarak ayarla) olarak bu projeyi seç 
            // süslü parantezlerin({}) adı : scope=kapsam
            // int : Tam sayı değişkeni
            // string : Metin değişkeni
            // double : Ondalıklı sayı değişkeni
            // char : Tek karakter değişkeni
            // bool : Mantıksal değişken

            #region 2-Değişkenler(Double)
            //double number;  
            //number = 4.85; 

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, PotatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //PotatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + "₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice);
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice);
            //Console.WriteLine("---- Patates Birim Fiyatı: " + PotatoPrice);
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice);

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = PotatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;
            //double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat : " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyat : " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyat : " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - Birim Fiyat : " + PotatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - Birim Fiyat : " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice);

            #endregion


            #region 2-Değişkenler(Char)
            // stringler "" ile tanımlanırken, char '' ile tanımlanır. 

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion


            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");   // imleç Yolcu Adı nın sağında kalacak ve aşağıdaki Readline ile kullanıcıdan veri girilebilecek
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " - İlçe/İl: " + passengerDistrict + "/" + passengerCity + " - Yaş: " + passengerAge); // yukarıda girilen klavye verilerini burada geri yazdımasını istedik



            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());   // Tam sayılarda doğrudan Console.ReadLine() kullanılmaz(çünkü bu string ifade tutar) bunun int türüne parse edilmesi gerekir.

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;

            //Console.WriteLine();

            //Console.WriteLine("Toplam Ödemeniz Gerken Tutar: " + totalPrice);

            #endregion


            #region Klavyeden Ondalıklı Sayı İşlemleri

            // *** Not: Code arayüzünde ondalıklı sayı yazarken arasına (.) konur, kullanıcıdan veri alma sırasında terminale (,) ile ondalıklı sayılar girilir.

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());         // eğer double a dönüştürülecekse double.Parse() kullanılır

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());     //Karakterler için dönüşüm char.Parse() ile yapılır

            Console.WriteLine();
            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender); 


            #endregion


            Console.Read();

        }
    }
}
