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
using System.Diagnostics;

namespace Flightfinder
{
    public partial class AddFlight : MetroFramework.Forms.MetroForm
    {
        public AddFlight()
        {
            InitializeComponent();
            DtpFlighttime.CustomFormat = DateTime.Now.ToString("HH:mm");
        }
        public string ConnectionString;
        public MySqlConnection connection;
        Functions Functions = new Functions();

        private void DtpFlighttime_MouseDown(object sender, MouseEventArgs e)
        {
            DtpFlighttime.CustomFormat = "HH:mm";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Functions.Startup();
            Functions.Opslaan(TxtArrival.Text, TxtCallsign.Text, TxtDeparture.Text, TxtRegistration.Text, DtpFlighttime.Value.TimeOfDay);
        }
        
        private void AddFlight_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Parent = null;
        }
    }
}
