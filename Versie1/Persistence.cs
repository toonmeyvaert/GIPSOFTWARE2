using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Versie1
{
    class Persistence
    {
        private string _connection;
        private MySqlConnection conn;

        public Persistence()
        {
            _connection = "server=localhost;user id=root;Password='Test123';database=database";
            conn = new MySqlConnection(_connection);
        }

        public List<Aankoop> getAankoopFromDB()
        {
            List<Aankoop> lijst = new List<Aankoop>();

            MySqlConnection conn = new MySqlConnection(_connection);
            MySqlCommand cmd = new MySqlCommand("select * from database.aankoop", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Aankoop aankoop1 = new Aankoop(Convert.ToDouble(dataReader["Prijs"]), Convert.ToInt32(dataReader["Aantal"]), dataReader["Voorwerp"].ToString());
                lijst.Add(aankoop1);
            }

            conn.Close();
            return lijst;
        }

        public void addAankoop(Aankoop item)
        {
            MySqlCommand cmd = new MySqlCommand("insert into aankoop" + "(Prijs, Aantal, Voorwerp) values ('" + item.prijs + "','" + item.aantal + "','" + item.voorwerp + "')", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
