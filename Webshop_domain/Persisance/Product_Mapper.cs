using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Webshop_domain.Business;

namespace Webshop_domain.Persisance
{
    class Product_Mapper
    {
		//Methods
		public List<Product> getProductFromDB(string connectionstring)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			MySqlCommand cmd = new MySqlCommand("SELECT * FROM webshop_database.product", conn);

			List<Product> itemLijst = new List<Product>();
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();


			while (dataReader.Read())
			{
				Product item = new Product(
				 Convert.ToInt16(dataReader[0]),
				 dataReader[1].ToString(),
				 dataReader[2].ToString(),
				 dataReader[3].ToString(),
				 Convert.ToDouble(dataReader[4])
				);
				itemLijst.Add(item);
			}
			conn.Close();
			return itemLijst;
		}
		public void addProductToDB(string connectionstring, Product item)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			string opdracht = "INSERT INTO webshop_database.product(Productnaam, Productcategorie, Omschrijving, Prijs) VALUES(@naam, @cate, @omsch, @prijs)";
			MySqlCommand cmd = new MySqlCommand(opdracht, conn);
			//voeg de waarden toe, je haalt ze uit het object eval
			cmd.Parameters.AddWithValue("@naam", item.ProductNaam);
			cmd.Parameters.AddWithValue("@cate", item.ProductCategorie);
			cmd.Parameters.AddWithValue("@omsch", item.Omschrijving);
			cmd.Parameters.AddWithValue("@prijs", item.Prijs);
			
			conn.Open();
			cmd.ExecuteNonQuery();
			conn.Close();
		}
		public bool DeleteFromProductenInDB(string connectionstring, int idproduct)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			string opdracht = "DELETE FROM webshop_database.product WHERE (IDProduct = @idlist)";
			MySqlCommand cmd = new MySqlCommand(opdracht, conn);
			//voeg de waarden toe, je haalt ze uit het object eval
			cmd.Parameters.AddWithValue("idlist", idproduct);

			conn.Open();
			try
			{
				cmd.ExecuteNonQuery();
			}
			catch
			{
				conn.Close();
				return false;
			}
			conn.Close();
			return true;
		}
	}
}
