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
    public partial class AddFlight : Form
    {
        public AddFlight()
        {
            InitializeComponent();
            DtpFlighttime.CustomFormat = DateTime.Now.ToString("HH:mm");
        }
        public string ConnectionString;
        public MySqlConnection connection;

        private void DtpFlighttime_MouseDown(object sender, MouseEventArgs e)
        {
            DtpFlighttime.CustomFormat = "HH:mm";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Startup();
            Opslaan();
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
        private void Opslaan()
        {
            if (this.Openconnection() == true && TxtArrival.Text != "" && TxtCallsign.Text != "" && TxtDeparture.Text != "" && TxtRegistration.Text != "")
            {
                //insert flightdata into database
                string query = "INSERT INTO flightfinder.Flightinfo (Departure, Arrival, Callsign, Registration, Flighttime) VALUES ('" + TxtDeparture.Text + "', '" + TxtArrival.Text + "', '" + TxtCallsign.Text + "', '" + TxtRegistration.Text + "', '" + DtpFlighttime.Value.TimeOfDay + "')";
                MySqlCommand Insert = new MySqlCommand(query, connection);
                Insert.ExecuteNonQuery();
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("failed");
            }
        this.Closeconnection();
        }

        private void AddFlight_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Parent = null;
        }
    }
}
