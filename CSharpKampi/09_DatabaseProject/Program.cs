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
            //Ado.net
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();
            string tableNumber;

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını  giriniz: ");
            tableNumber = Console.ReadLine();   
            Console.WriteLine("------------------------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCategory",connection); //sql sorgu,hangi veritabanı olduğunu bulsun diye connection
            SqlDataAdapter adapter = new SqlDataAdapter(command); //sorgu ile sql veritabanı arasındaki köprü
            DataTable dataTable = new DataTable();//verileri geçici belleğe almayı sağlicak
            adapter.Fill(dataTable);
            connection.Close();

            //satırlar arasında dolaşacak
            foreach (DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }


            


            Console.Read();
        }
    }
}
