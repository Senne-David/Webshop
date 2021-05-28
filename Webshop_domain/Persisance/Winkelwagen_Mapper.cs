using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_domain.Business;
using MySql.Data.MySqlClient;

namespace Webshop_domain.Persisance
{
    class Winkelwagen_Mapper
    {
		//Methods
		public List<Winkelwagen> getAfgerekendeMandjesFromDB(string connectionstring)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			MySqlCommand cmd = new MySqlCommand("SELECT IDWinkelwagen, Datum, Verzendkosten, Kaartnummer, Verzendmethode, FK_Klant, klant.Gebruikersnaam, afgerekend FROM webshop_database.winkelwagen inner join webshop_database.klant on winkelwagen.FK_Klant = klant.IDKlant where afgerekend = 1", conn);
			

			List<Winkelwagen> itemLijst = new List<Winkelwagen>();
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();


			while (dataReader.Read())
			{
				Winkelwagen item = new Winkelwagen(
				 Convert.ToInt16(dataReader[0]),
				 dataReader[1].ToString(),
				 Convert.ToDouble(dataReader[2]),
				 dataReader[3].ToString(),
				 dataReader[4].ToString(),
				 Convert.ToInt32(dataReader[5]),
				 dataReader[6].ToString(),
				 Convert.ToInt32(dataReader[7])
				);
				itemLijst.Add(item);
			}
			conn.Close();
			return itemLijst;
		}
		public int addWinkelwagenToDB(string connectionstring,Winkelwagen item)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			string opdracht = "INSERT INTO webshop_database.winkelwagen (Datum, Verzendkosten, Kaartnummer, Verzendmethode, FK_Klant, afgerekend) VALUES(@date, @verk, @knum, @verm, @FKkla, @status)";
			MySqlCommand cmd = new MySqlCommand(opdracht, conn);
			//voeg de waarden toe, je haalt ze uit het object eval
			cmd.Parameters.AddWithValue("@date", item.Datum);
			cmd.Parameters.AddWithValue("@verk", item.Verzendkosten);
			cmd.Parameters.AddWithValue("@knum", item.Kaartnummer);
			cmd.Parameters.AddWithValue("@verm", item.Verzendmethode);
			cmd.Parameters.AddWithValue("@FKkla", item.FKklant);
			cmd.Parameters.AddWithValue("@status", item.Afgerekend);
			MySqlCommand cmd2 =new MySqlCommand("SELECT max(IDWinkelwagen) FROM webshop_database.winkelwagen", conn);
			conn.Open();
			int idWinkelkar = 0;
			
				cmd.ExecuteNonQuery();
				MySqlDataReader Reader = cmd2.ExecuteReader();
				while(Reader.Read())
                {
					idWinkelkar = Convert.ToInt32(Reader[0]);
                }
				
			
			
			conn.Close();
			return idWinkelkar;
		}
		public bool UpdateWinkelwagenInDB(string connectionstring, int idWinkelwagen)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			string opdracht = "UPDATE webshop_database.winkelwagen SET afgerekend = '1' WHERE(IDWinkelwagen = @idWinkelwagen)";
			MySqlCommand cmd = new MySqlCommand(opdracht, conn);
			//voeg de waarden toe, je haalt ze uit het object eval
			cmd.Parameters.AddWithValue("@idWinkelwagen", idWinkelwagen);

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
