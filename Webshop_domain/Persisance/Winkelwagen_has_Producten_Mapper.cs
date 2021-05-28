using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_domain.Business;
using MySql.Data.MySqlClient;

namespace Webshop_domain.Persisance
{
    class Winkelwagen_has_Producten_Mapper
    {
        //Methods
        public List<Winkelwagen_has_Producten> getWinkelwagen_has_ProductFromDB(string connectionstring, int idwinkelwagen)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(connectionstring);
            
            //Het SQL-commando definiëren
            MySqlCommand cmd = new MySqlCommand("SELECT IDProduct_In_Winkelwagen, Aantal, FK_Product, product.Productnaam, product.Prijs, FK_Winkelwagen " +
                "FROM webshop_database.winkelwagen_has_producten " +
                "inner join webshop_database.product on winkelwagen_has_producten.FK_Product = product.IDProduct " +
                "WHERE FK_Winkelwagen = @fkwinkel", conn);
            cmd.Parameters.AddWithValue("fkwinkel", idwinkelwagen);

            List<Winkelwagen_has_Producten> itemLijst = new List<Winkelwagen_has_Producten>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            


            while (dataReader.Read())
            {
                Winkelwagen_has_Producten item = new Winkelwagen_has_Producten(
                 Convert.ToInt16(dataReader[0]),
                 Convert.ToInt16(dataReader[1]),
                 Convert.ToInt16(dataReader[2]),
                 Convert.ToString(dataReader[3]),
                 Convert.ToDouble(dataReader[4]),
                 Convert.ToInt32(dataReader[5])
                );
                itemLijst.Add(item);
            }
            conn.Close();
            return itemLijst;
        }
        
        public double getTotaalFromDB(string connectionstring, int idwinkelwagen)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(connectionstring);

            //Het SQL-commando definiëren
            MySqlCommand cmd = new MySqlCommand("SELECT IDWinkelwagen, sum(aantal* prijs) as totaal " +
                "FROM webshop_database.winkelwagen_has_producten " +
                "inner join webshop_database.product on winkelwagen_has_producten.FK_Product = product.IDProduct " +
                "inner join webshop_database.winkelwagen on winkelwagen_has_producten.FK_Winkelwagen = winkelwagen.IDWinkelwagen " +
                "where FK_Winkelwagen = @fkwinkelwagen", conn);
            cmd.Parameters.AddWithValue("fkwinkelwagen", idwinkelwagen);

            
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();



            while (dataReader.Read())
            {
                if (dataReader[0] is DBNull)
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(dataReader[1]);
                }
            }
            conn.Close();
            return 0;
        }
        public bool addWinkalwagen_has_ProductenToDB(string connectionstring, int winkelwagen, int aantal, int idproduct)
		{
			//de connectie met de databank maken
			MySqlConnection conn = new MySqlConnection(connectionstring);

			//Het SQL-commando definiëren
			string opdracht = "INSERT INTO webshop_database.winkelwagen_has_producten(Aantal, FK_Product, FK_Winkelwagen) VALUES(@aant, @FKpro, @FkWink)";
			MySqlCommand cmd = new MySqlCommand(opdracht, conn);
			//voeg de waarden toe, je haalt ze uit het object eval
			cmd.Parameters.AddWithValue("@aant", aantal);
			cmd.Parameters.AddWithValue("@FKpro", idproduct);
			cmd.Parameters.AddWithValue("@FKWink", winkelwagen);

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

        public bool DeleteFromWinkelwagenInDB(string connectionstring, int idproductInWinkelwagen)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(connectionstring);

            //Het SQL-commando definiëren
            string opdracht = "DELETE FROM webshop_database.winkelwagen_has_producten WHERE (IDProduct_In_Winkelwagen = @idwinkelwagenlist)";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            //voeg de waarden toe, je haalt ze uit het object eval
            cmd.Parameters.AddWithValue("@idwinkelwagenlist", idproductInWinkelwagen);

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
