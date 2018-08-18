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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public DateTime timeframe;
        AddFlight addflightform = new AddFlight();
        public string ConnectionString;
        public MySqlConnection connection;
        public string Departure;
        public string Arrival;
        public string Callsign;
        public string Registration;
        public string Flighttime;
        private void BtnFlight_Click(object sender, EventArgs e)
        {
            //open the add flight menu
            addflightform.Show();          
        }

        private void BtnTime_Click(object sender, EventArgs e)
        {
            //open the settimeframe form
            SetTimeFrame settimeframeform = new SetTimeFrame(this);
            settimeframeform.Show();
        }

        internal void PopulateLabel()
        {
            //With this function the current set timeframe will be set in the timeframelabel
            LblTimeframe.Text = "Current set timeframe: " + timeframe.ToString("dd/MM/yyyy HH:mm");
        }

        internal void SearchFlights()
        {
            //In this function the possible flight will be searched
            LstPossible.Items.Clear();
            Startup();
            Openconnection();
            Search();
        }
        private void Search()
        {
            TimeSpan flighttime = timeframe.Subtract(DateTime.Now);
            string Searchstring = "SELECT Departure, Arrival, Callsign FROM Flightinfo WHERE Flighttime < '" + flighttime.ToString() + "'";
            IDbCommand dbCommand = connection.CreateCommand();
            dbCommand.CommandText = Searchstring;
            IDataReader reader = dbCommand.ExecuteReader();
            while (reader.Read())
            {
                string Departure = (string)reader["Departure"];
                string Arrival = (string)reader["Arrival"];
                string Callsign = (string)reader["Callsign"];
                LstPossible.Items.Add(Departure + " " + Arrival + " " + Callsign);
            }
            if (LstPossible.Items.Count < 1)
            {
                LstPossible.Items.Add("No flights available");
            }
            reader.Close();
            reader = null;
            dbCommand.Dispose();
            dbCommand = null;
        }   
        private void Startup()
        {
            string server = "db4free.net";
            string database = "flightfinder";
            string uid = "tom0205";
            string password = "Tom02052001";

            ConnectionString = "SERVER=" + server + "; DATABASE=" + database + "; UID=" + uid + "; PASSWORD=" + password + "; old guids=true; CharSet=utf8;";
            connection = new MySqlConnection(ConnectionString);
        }
        private bool Openconnection()
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
        private bool Closeconnection()
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

        private void LstPossible_DoubleClick(object sender, EventArgs e)
        {
            FlightInfo Flightinfo = new FlightInfo(this);
            //let's you see all the data of the selected flight
            string Selectedflight = LstPossible.GetItemText(LstPossible.SelectedItem);
            string[] Selectedflightstring = Selectedflight.Split(' ');
            Departure = Selectedflightstring[0];
            Arrival = Selectedflightstring[1];
            Callsign = Selectedflightstring[2];
            string Searchstring = "SELECT Flighttime, Registration FROM Flightinfo WHERE Departure = '" + Departure + "' AND Arrival = '" + Arrival+ "' AND Callsign = '" + Callsign+ "'";
            IDbCommand dbCommand = connection.CreateCommand();
            dbCommand.CommandText = Searchstring;
            IDataReader reader = dbCommand.ExecuteReader();
            while (reader.Read())
            {
                Flighttime = reader["Flighttime"].ToString();
                Registration = reader["Registration"].ToString();
            }
            reader.Close();
            reader = null;
            dbCommand.Dispose();
            dbCommand = null;
            Flightinfo.Show();
        }
    }
}
