using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik üçgen

            //for (int i = 0; i <= 5; i++)           // burada döngü başlar aşağıya inince j <= 2 olana kadar yıldız yazar, sonra tekrar ilk for döngüsüne geçer, burada i = 2 için yeniden j döngüsüne girer ve bu böyle devam eder i = 5 olana kadar. Alt alta 5 ve yan yana 2 yıldız yazmış olur 
            //{
            //    for (int j = 1; j <= i; j++)      // burada üçgen elde edebilmem için j <= 2 yi j <= i olarak yazarım ve üçgen şeklinde yıldızlar ekrana yazılır. i = 1 olduğunda j = 1 olur, i = 2 olduğunda j = 2 olur ve böyle devam ederek üçgen oluşturulur 
            //    {
            //        Console.Write("*");
            //    }   
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik üçgen

            //for (int i = 5; i >= 1; i--)           
            //{
            //    for (int j = 1; j <= i; j++)      
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik ve Ters Dik üçgen beraber

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(); 
            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++) 
            //    { 
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi

            // üst kısım
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n-1; j > 0; j--)    // soldan 4 karakter boşluk bıraktık 
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)   // sırayla 1 - 3 - 5 - 7 - 9 adet yıldız yazacak
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            // alt kısım
            //for (int i = n - 1; i >= 1; i--)     // yukarıdakinin tersi
            //{
            //    for (int j = n - 1; j > 0; j--)   // soldan 4 karakter boşluk bıraktık 
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit

            //int n = 5;
            //for (int i = 1; i <= n; i++)         
            //{
            //    // boşluklar için; her döngüde sırayla 4 - 3 - 2 - 1 boşluk bırakır
            //    for (int j = n - i; j > 0; j--)        
            //    {
            //        Console.Write(" ");
            //    }

            //    // yıldızlar için; her döngüde 1 - 3 - 5 - 7 - 9 adet yıldız yazar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    // boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    // yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();       // bu kod ile her döngüde bir alta inecek satır oluşturulur
            //}

            #endregion



            Console.Read();
        }
    }
}
