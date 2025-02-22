using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRUD ---> Create - Read - Update- Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli");
            Console.WriteLine();

            Console.WriteLine("-------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            // Data Source : Sql connection bağlantı ismi
            // initial Catalog : kullandığımız veri tabanı ismi

            //SqlConnection connection = new SqlConnection("Data Source=ALPEREN\\MSSQL2022;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            // insert : ekleme sorgusu, into : içine ekle
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection); // TblCategory içine CategoryName ekle ve bu değerleri parametre bir den al. Son olarak connection(yukarıdaki veri tabanı adresi) ile ilişkilendirdik. 
            //command.Parameters.AddWithValue("@p1", categoryName); 
            // Vs de hiyerarşik atama -> (productname, price, stock) values (@p1, @p2, @p3) burada sol taraftaki parantez sıralaması ile sağ taraftaki parantez sıralaması birbiri ile sırayla eşleşerek çalışır
            //command.ExecuteNonQuery();   // koşulsuz bir şekilde sorguyu çalıştır
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi!");

            #endregion

            #region Ürün Ekleme(Insert) İşlemi 

            //string productName;
            //decimal productPrice;
            //bool ProductStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data source=ALPEREN\\MSSQL2022;initial catalog=EgitimKampiDb;integrated security=true");     // Sql bağlantısı yapıldı      
            //connection.Open();   // bağlantı açıldı
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);   // ekleme işlemi yapılacak bunun için tablo ismi ve tablo içerisinde bulunan sütun başlıkları seçildi. Yukarıdaki connection ile ilişkilendirildi
            // Birden fazla parametremiz var ve bunları aşağıda tanımladık.
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);   // eklediğim ürünlerin aktif olmasını istedim
            //command.ExecuteNonQuery();    // değişiklikleri kaydet ve bunları veri tabanına ekle anlamına gelir.
            //connection.Close();     // bağlantıyı kapattık
            //Console.WriteLine("Ürün eklemesi başarılı!");   // kod çalıştığında bir mesaj döndürmesini istedik

            #endregion

            #region Ürün Listeleme(Select) İşlemi

            //SqlConnection connection = new SqlConnection("Data source=ALPEREN\\MSSQL2022;initial catalog=EgitimKampiDb;integrated security=true");   // Bunu sürekli kullandığımız için ileride bunu bir sınıfa atayıp oradan çekebileceğiz.

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);   // Veri listelemede köprü görevi görür. Sql deki verileri C# tarafına çekecek olan bir köprü
            //DataTable dataTable = new DataTable();  // verileri geçici belleğe almak için bu sınıftan(DataTable) bir nesne örneği oluşturduk.
            //adapter.Fill(dataTable);   // veritabanından sorgu sonucu dönen verileri alır ve dataTable nesnesine doldurur.


            //foreach (DataRow row in dataTable.Rows)    // DataRow, bir dataTable içindeki bir satırı temsil eder. Bu ifade, bir DataTable nesnesinin satırlarını (Rows koleksiyonunu) döngüyle gezmek için kullanılır.
            //{
            //    foreach (var item in row.ItemArray)   // üstteki foreach ile satırları gezdk fakat birden fazla sütunumuzda var. Bu ilgili satırın sütunları için de ayrı ayrı yazdırmamız gerek, bunun için burada da foreach kullandık      
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme(Delete) İşlemi

            // Ürün silme işlemi için id kullanırız.

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=ALPEREN\\MSSQL2022;initial catalog=EgitimKampiDb;integrated security=true");  // veritabanı bağlantısı yapıldı

            //connection.Open(); // bağlantı açıldı

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where Productid=@productId", connection);  // Sql sorgusunu çalıştırmak ve veritabanı ile etkileşim kurmak için SqlCommand sınıfından yeni bir nesne oluşturduk. Silme işlemi için sql sorgusu yazıldı
            //command.Parameters.AddWithValue("@productId", productId);  // SQL sorgularında parametre kullanarak değişkenleri veritabanına güvenli bir şekilde iletmek için kullanılır.
            //command.ExecuteNonQuery(); // değişiklikler veri tabanına yansıtılır

            //connection.Close();  // bağlantı kapatıldı

            //Console.WriteLine("Silme işlemi yapıldı!");

            #endregion

            #region Ürün Güncelleme(Update) İşlemi

            // Öncelikle güncellenecek kısımlar kullanıcıdan alınır
            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=ALPEREN\\MSSQL2022;Initial Catalog=EgitimKampiDb;Integrated Security=true");
            
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where Productid=@productId", connection); // Set : ayarla, güncelleme yaparken şart(where) yazılmak zorunda yoksa tüm kayıtları günceller. // Sql güncelleme sorgusu yazıldı
            //// parametreler girildi
            //command.Parameters.AddWithValue("productName", productName);
            //command.Parameters.AddWithValue("productPrice", productPrice);
            //command.Parameters.AddWithValue("productId", productId);
            //command.ExecuteNonQuery(); // değişiklikler sql e kaydedilir

            //connection.Close();

            //Console.WriteLine("Güncelleme başarılı!");


            #endregion

            Console.Read();

        }
    }
}
