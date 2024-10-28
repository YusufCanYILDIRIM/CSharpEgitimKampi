﻿using System;
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

			//sql yapılarını kullanabilmemize olanak sağlayan bir çerçeve

			Console.WriteLine("***** C# Veri tabanlı ürün kategori bilgi sistemi *****");
			Console.WriteLine();
			Console.WriteLine();

			string tblNumber;

			Console.WriteLine("-----------------------------");
			Console.WriteLine("1-Kategoriler");
			Console.WriteLine("2-Ürünler");
			Console.WriteLine("3-Siparişler");
			Console.WriteLine("4-Çıkış Yap");
			Console.Write("Lütfen getirmek istediğiniz tablo numarsını giriniz :");
			tblNumber = Console.ReadLine();
			Console.WriteLine("-----------------------------");

			SqlConnection connection = new SqlConnection("Data Source = ASUS; initial Catalog=EgitimKampiDb; TrustServerCertificate=True; integrated security=true;");
			connection.Open();
			SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);

			foreach(DataRow row in dataTable.Rows)
			{
				foreach(var item in row.ItemArray)
				{
					Console.Write(item.ToString());
				}
				Console.WriteLine();
			}

			connection.Close();

			Console.Read();
		}
	}
}