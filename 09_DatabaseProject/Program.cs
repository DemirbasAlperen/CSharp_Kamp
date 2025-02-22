using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sql Özellikleri

            // Sql veri tabanı ve tablo oluşturma & C# kısmına bağlama
            // Id : Identity : Kimlik
            /* Sql ' de veri tipleri; 
             - bit(aktif-pasif) : C# da bool türünün karşılığıdır.
             - char : sabit uzunluktaki karakterler için kullanılır.(Tc ve telefon numarası gibi)
             - decimal : ondalıklı sayılar için kullanılır
             - date ve datetime : tarih ve zaman formatları için kullanılır.
             - int : tam sayı türündeki veriler için kullanılır.
             - varchar : veri uzunluğu sabit değil ise kullanılır.(isim - soyisim -ülke isimleri gibi...)
             - nvarchar : Hem Unicode olmayan hem de Unicode (yani japonca, korece vb.) karakterler depolanabilir
             - Tinyint, 0 ile 255 arasındaki sayıları tutmak için kullanılır. Veritabanında 1 byte'lık yer kaplar.
            */
            // PRIMARY KEY; bir tabloda bulunan veri sıralarını birbirinden ayırmamızı sağlayan bir kısıtlama (constraint) yapısıdır.
            // CategoryId de vermiş olduğumuz sayıların otomatik olarak yazılması için -> Category tablosuna gel aşağıdaki menüden Identity Specification seçeneğine gel ve altında bulunan (Is Identity) seçeneğini no dan yes e çevir. Bu durumda başlangıç 1 den olacak şekilde bir er bir er artış olacaktır

            #endregion


            #region Ado.net Kullanarak Sql Bağlama

            // Ado.net : Kullanacağımız yapı. Aynı zamanda c# programlama dilinde sql yapılarını kullanmamızı sağlayan bir kütüphanedie

            Console.WriteLine("***** C# Veri Tabanlı Ürün - Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen erişmek istedğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-----------------------------------");

            // SQL bağlantısı: SqlConnection ı kullanarak sql bağlantısı yapılır. SqlConnection("") => tırnak içine sql adresi girilecek
            SqlConnection connection = new SqlConnection("Data Source=ALPEREN\\MSSQL2022;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();  // bağlantıyı açtık
            SqlCommand command = new SqlCommand("Select * From TblCategory" ,connection);    // tırnak içine bir sql sorgusu yazıyoruz ve tablomun hangi veritabanında olduğunu belirtmek için connection umu verdim
            SqlDataAdapter adapter = new SqlDataAdapter(command);  // burada oluşturduğum sorgu ile sql veritabanı arasında bir köprü görevi görecek
            DataTable dataTable = new DataTable();   // dataTable nesne örneği oluşturdum bu sayede verileri geçici belleğe alabilirim
            adapter.Fill(dataTable);
            connection.Close(); // bağlantıyı kapattım

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();
        }
    }
}
