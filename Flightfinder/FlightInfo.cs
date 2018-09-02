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
    public partial class FlightInfo : Form
    {
        public FlightInfo(Main incomingform)
        {
            mainform = incomingform;
            InitializeComponent();
        }
        Main mainform;
        public string ConnectionString;
        public MySqlConnection connection;

        private void FlightInfo_Load(object sender, EventArgs e)
        {
            //Shows flightinfo in textboxes
            TxtDeparture.Text = mainform.Departure;
            TxtArrival.Text = mainform.Arrival;
            TxtCallsign.Text = mainform.Callsign;
            TxtRegistration.Text = mainform.Registration;
            DtpFlighttime.CustomFormat = mainform.Flighttime;
        }

        private void BtnVerwijder_Click(object sender, EventArgs e)
        {
            Startup();
            Openconnection();
            string Deletestring = "DELETE FROM `Flightinfo` WHERE Departure = '" + mainform.Departure + "' AND Arrival = '" + mainform.Arrival + "' AND Callsign = '" + mainform.Callsign + "' AND Registration = '" + TxtRegistration.Text + "'";
            IDbCommand dbCommand = connection.CreateCommand();
            dbCommand.CommandText = Deletestring;
            IDataReader Deleter = dbCommand.ExecuteReader();
            Deleter.Close();
            Deleter = null;
            dbCommand.Dispose();
            dbCommand = null;
            MessageBox.Show("Deleted");
            mainform.SearchFlights();
            this.Close();
        }

        public void Startup()
        {
            string server = "db4free.net";
            string database = "flightfinder";
            string uid = "tom0205";
            string password = "Tom02052001";

            ConnectionString = "SERVER=" + server + "; DATABASE=" + database + "; UID=" + uid + "; PASSWORD=" + password + "; old guids=true; CharSet=utf8;";
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
