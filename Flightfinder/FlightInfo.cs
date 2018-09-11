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
    public partial class FlightInfo : MetroFramework.Forms.MetroForm
    {
        public FlightInfo(Main incomingform)
        {
            mainform = incomingform;
            InitializeComponent();
        }
        Main mainform;
        public string ConnectionString;
        public MySqlConnection connection;
        Functions Functions = new Functions();

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
            Functions.Startup();
            Functions.Openconnection();
            string Deletestring = "DELETE FROM `Flightinfo` WHERE Departure = '" + mainform.Departure + "' AND Arrival = '" + mainform.Arrival + "' AND Callsign = '" + mainform.Callsign + "' AND Registration = '" + TxtRegistration.Text + "'";
            IDataReader Deleter = Functions.fGetDbcommand(Deletestring).ExecuteReader();
            Deleter.Close();
            Deleter = null;
            Functions.fGetDbcommand(Deletestring).Dispose();
            MessageBox.Show("Deleted");
            mainform.SearchFlights();
            this.Close();
        }
    }
}
