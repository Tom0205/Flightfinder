using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Flightfinder
{
    class Functions
    {
        MySqlConnection connection;

        public IDbCommand fGetDbcommand(string query)
        {
            IDbCommand dbCommand = connection.CreateCommand();
            dbCommand.CommandText = query;
            
            return dbCommand;
        }

        public void Opslaan(string Arrival, string Callsign, string Departure, string Registration, TimeSpan FlightTime)
        {
            if (Openconnection() == true && Arrival != "" && Callsign != "" && Departure != "" && Registration != "")
            {
                //insert flightdata into database
                string query = "INSERT INTO flightfinder.Flightinfo (Departure, Arrival, Callsign, Registration, Flighttime) VALUES ('" + Departure + "', '" + Arrival + "', '" + Callsign + "', '" + Registration + "', '" + FlightTime + "')";
                MySqlCommand Insert = new MySqlCommand(query, connection);
                Insert.ExecuteNonQuery();
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("failed");
            }
            Closeconnection();
        }

        public void Startup()
        {
            string server = "db4free.net";
            string database = "flightfinder";
            string uid = "tom0205";
            string password = "Tom02052001";

            string ConnectionString = "SERVER=" + server + "; DATABASE=" + database + "; UID=" + uid + "; PASSWORD=" + password + "; old guids=true; CharSet=utf8;";
            connection = new MySqlConnection(ConnectionString);
        }

        public bool Openconnection()
        {
            //open connectie
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Closeconnection()
        {
            //close connectie
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
