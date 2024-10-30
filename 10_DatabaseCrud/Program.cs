using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
			//Crud -> Created - Read - Update - Deleted

			Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
			Console.WriteLine();

			Console.WriteLine("-----------------------");
			#region Kategori Ekleme İşlemi
			//Console.Write("Eklemek istediğiniz kategori adı :");
			//string categoryName = Console.ReadLine();

			//SqlConnection connection = new SqlConnection("Data Source = ASUS; initial Catalog=EgitimKampiDb; TrustServerCertificate=True; integrated security=true;");
			//connection.Open();

			//SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
			//command.Parameters.AddWithValue("@p1", categoryName);
			//command.ExecuteNonQuery();
			//connection.Close();

			//Console.Write("Kategori başarıyla yüklendi");
			#endregion

			#region Ürün Ekleme İşlemi
			//string productName;
			//decimal productPrice;
			//bool productStatus;

			//Console.Write("Ürün Adı : ");
			//productName = Console.ReadLine();

			//Console.Write("Ürün fiyatı : ");
			//productPrice = Convert.ToDecimal(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source = ASUS; initial Catalog=EgitimKampiDb; TrustServerCertificate=True; integrated security=true;");
			//connection.Open();

			//SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
			//command.Parameters.AddWithValue("@productName", productName);
			//command.Parameters.AddWithValue("@productPrice", productPrice);
			//command.Parameters.AddWithValue("@productStatus", true);
			//command.ExecuteNonQuery();
			//connection.Close();

			//Console.Write("ürün eklemesi başarılı");
			#endregion

			#region Ürün Listeleme İşlemi

			//SqlConnection connection = new SqlConnection("Data Source = ASUS; initial Catalog=EgitimKampiDb; TrustServerCertificate=True; integrated security=true;");
			//connection.Open();
			//SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
			//SqlDataAdapter adapter = new SqlDataAdapter(command);
			//DataTable dataTable = new DataTable();
			//adapter.Fill(dataTable);

			//foreach (DataRow row in dataTable.Rows)
			//{
			//	foreach(var item in row.ItemArray)
			//	{
			//		Console.Write(item.ToString() + " ");
			//	}
			//	Console.WriteLine();	
			//}


			//connection.Close();
			#endregion

			#region Ürün Silme İşlemi

			//Console.Write("silmek istediğiniz ürünün Id'sini giriniz : ");
			//int productId = int.Parse(Console.ReadLine());


			//SqlConnection connection = new SqlConnection("Data Source = ASUS; initial Catalog=EgitimKampiDb; TrustServerCertificate=True; integrated security=true;");
			//connection.Open();
			//SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
			//command.Parameters.AddWithValue("@productId",productId);
			//command.ExecuteNonQuery();

			//connection.Close();
			//Console.WriteLine("silme işlemi başarılı!");
			#endregion

			#region Ürün Güncelleme İşlemi

			Console.Write("güncellenecek ürün id :");
			int productId = int.Parse(Console.ReadLine());

			Console.Write("güncellenecek ürün adı :");
			string productName = Console.ReadLine();

			Console.Write("güncellencek ürün fiyatı : ");
			decimal productPrice = decimal.Parse(Console.ReadLine());


			SqlConnection connection = new SqlConnection("Data Source = ASUS; initial Catalog=EgitimKampiDb; TrustServerCertificate=True; integrated security=true;");
			connection.Open();
			SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice Where ProductId=@productId",connection);
			command.Parameters.AddWithValue("@productName",productName);
			command.Parameters.AddWithValue("@productPrice",productPrice);
			command.Parameters.AddWithValue("@productId",productId);
			command.ExecuteNonQuery();
			connection.Close();

			Console.Write("güncelleme başarılı!");
			#endregion

			Console.Read();
		}
	}
}
