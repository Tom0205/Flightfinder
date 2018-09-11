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
using System.Threading;

namespace Flightfinder
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            Thread t = new Thread(new ThreadStart(Functions.Startscreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();    
        }
        public DateTime timeframe;
        AddFlight addflightform = new AddFlight();
        Functions Functions = new Functions();
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
            try
            {
                Functions.Startup();
                Functions.Openconnection();
                Search();
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, the Database is offline");
                throw;
            }     
        }

        public void Search()
        {
            TimeSpan flighttime = timeframe.Subtract(DateTime.Now);
            string Searchstring = "SELECT Departure, Arrival, Callsign FROM Flightinfo WHERE Flighttime < '" + flighttime.ToString() + "'";
            IDataReader reader = Functions.fGetDbcommand(Searchstring).ExecuteReader();
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
            Functions.fGetDbcommand(Searchstring).Dispose();
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
            IDataReader reader = Functions.fGetDbcommand(Searchstring).ExecuteReader();
            while (reader.Read())
            {
                Flighttime = reader["Flighttime"].ToString();
                Registration = reader["Registration"].ToString();
            }
            reader.Close();
            reader = null;
            Functions.fGetDbcommand(Searchstring).Dispose();
            Flightinfo.Show();
        }
    }
}
