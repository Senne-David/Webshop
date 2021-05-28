using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Webshop_domain.Business;

namespace Webshop_domain.Persisance
{
    class Klant_Mapper
    {
		public Klant SearchKlantInDB(string connectionstring, string naam, string paswoord)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			MySqlCommand cmd = new MySqlCommand("SELECT * FROM webshop_database.klant WHERE Gebruikersnaam = @naam and Paswoord = @paswoord", conn);
			cmd.Parameters.AddWithValue("naam", naam);
			cmd.Parameters.AddWithValue("paswoord", paswoord);

			Klant klant = null;
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				// datareaders nog aanpassen!
				klant = new Klant(
				Convert.ToInt16(dataReader[0]),
				 dataReader[1].ToString(),
				 dataReader[2].ToString(),
				 dataReader[3].ToString(),
				 dataReader[4].ToString(),
				 dataReader[5].ToString(),
				 Convert.ToInt16(dataReader[8]),
				 dataReader[7].ToString(),
				 Convert.ToInt16(dataReader[8]),
				 dataReader[9].ToString(),
				 dataReader[10].ToString()
				);
			}
			conn.Close();
			return klant;

		}

		//Methods
		public List<Klant> getKlantFromDB (string connectionstring)
        {
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			MySqlCommand cmd = new MySqlCommand("SELECT * FROM webshop_database.klant", conn);

			List<Klant> itemLijst = new List<Klant>();
			conn.Open();
			MySqlDataReader dataReader = cmd.ExecuteReader();


			while (dataReader.Read())
			{
				Klant item = new Klant(
				 Convert.ToInt16(dataReader[0]),
				 dataReader[1].ToString(),
				 dataReader[2].ToString(),
				 dataReader[3].ToString(),
				 dataReader[4].ToString(),
				 dataReader[5].ToString(),
				 Convert.ToInt16(dataReader[8]),
				 dataReader[7].ToString(),
				 Convert.ToInt16(dataReader[8]),
				 dataReader[9].ToString(),
				 dataReader[10].ToString()
				);
				itemLijst.Add(item);
			}
			conn.Close();
			return itemLijst;
		}
		public bool addKlantToDB(string connectionstring, string gebruikersnaam, string paswoord, string voornaam, string achternaam, string geboortedatum, int postcode, string straat, int huisnummer, string email, string telefoon)
        {
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			string opdracht = "INSERT INTO `webshop_database`.`klant` (`Gebruikersnaam`, `Paswoord`, `Voornaam`, `Achternaam`, `Geboortedatum`, `Postcode`, `Straat`, `Huisnummer`, `E-mail`, `Telefoonnummer`) VALUES (@geb, @pas, @vn, @an, @gd, @pc, @str, @hn, @Em, @tel)";
			MySqlCommand cmd = new MySqlCommand(opdracht, conn);
			//voeg de waarden toe, je haalt ze uit het object eval
			cmd.Parameters.AddWithValue("@geb", gebruikersnaam);
			cmd.Parameters.AddWithValue("@pas", paswoord);
			cmd.Parameters.AddWithValue("@vn", voornaam);
			cmd.Parameters.AddWithValue("@an", achternaam);
			cmd.Parameters.AddWithValue("@gd", geboortedatum);
			cmd.Parameters.AddWithValue("@pc", postcode);
			cmd.Parameters.AddWithValue("@str", straat);
			cmd.Parameters.AddWithValue("@hn", huisnummer);
			cmd.Parameters.AddWithValue("@Em", email);
			cmd.Parameters.AddWithValue("@tel", telefoon);

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


