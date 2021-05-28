using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Webshop_domain.Business;

namespace Webshop_domain.Persisance
{
    class Verlanglijstje_Mapper
    {
		//Methods

		public List<Verlanglijst> getVerlanglijstjeFromDB(string connectionstring, int idklant)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			MySqlCommand cmd = new MySqlCommand("SELECT IDVerlanglijstje, FK_Product, product.Productnaam, FK_Klant " +
				"FROM webshop_database.verlanglijstje " +
				"inner join webshop_database.product on verlanglijstje.FK_Product = product.IDProduct " +
				"WHERE FK_Klant = @Klant", conn);
			cmd.Parameters.AddWithValue("Klant", idklant);
			List<Verlanglijst> itemLijst = new List<Verlanglijst>();
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();


			while (dataReader.Read())
			{
				Verlanglijst item = new Verlanglijst(
				 Convert.ToInt16(dataReader[0]),
				 Convert.ToInt16(dataReader[1]),
				 Convert.ToString(dataReader[2]),
				 Convert.ToInt16(dataReader[3])
				);
				itemLijst.Add(item);
			}
			conn.Close();
			return itemLijst;
		}
        public bool DeleteFromVerlanglijstjeInDB(string connectionstring, int idverlanglijst)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(connectionstring);

            //Het SQL-commando definiëren
            string opdracht = "DELETE FROM webshop_database.verlanglijstje WHERE (IDVerlanglijstje = @idlist)";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            //voeg de waarden toe, je haalt ze uit het object eval
            cmd.Parameters.AddWithValue("idlist", idverlanglijst);

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
        public bool addVerlanglijstjeToDB(string connectionstring, int idproduct, int idklant)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			string opdracht = "INSERT INTO webshop_database.verlanglijstje (FK_Product, FK_Klant) VALUES (@FKpro, @FKkla)";
			MySqlCommand cmd = new MySqlCommand(opdracht, conn);
			//voeg de waarden toe, je haalt ze uit het object eval
			cmd.Parameters.AddWithValue("@Fkpro", idproduct);
			cmd.Parameters.AddWithValue("@FKkla", idklant);

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
		public List<Verlanglijst> getAlgemeneVerlanglijst(string connectionstring)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			MySqlCommand cmd = new MySqlCommand("SELECT IDVerlanglijstje, FK_Product, product.Productnaam, FK_Klant" +
				" FROM webshop_database.verlanglijstje " +
				"inner join webshop_database.product on verlanglijstje.FK_Product = product.IDProduct", conn);
			List<Verlanglijst> itemLijst = new List<Verlanglijst>();
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();


			while (dataReader.Read())
			{
				Verlanglijst item = new Verlanglijst(
				 Convert.ToInt16(dataReader[0]),
				 Convert.ToInt16(dataReader[1]),
				 Convert.ToString(dataReader[2]),
				 Convert.ToInt16(dataReader[3])
				);
				itemLijst.Add(item);
			}
			conn.Close();
			return itemLijst;
		}

	}
}
