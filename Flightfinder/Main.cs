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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public string timeframe;
        public string Dateframe;
        AddFlight addflightform = new AddFlight();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Dateframe.ToString() + " " +timeframe.ToString("HH:mm"));
        }
    }
}
