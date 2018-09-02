using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string query = "DELETE FROM `Flightinfo` WHERE Departure = '" + mainform.Departure + "' AND Arrival = '" + mainform.Arrival + "' AND Callsign = '" + mainform.Callsign + "' AND Registration = '" + TxtRegistration.Text + "'";
        }
    }
}
