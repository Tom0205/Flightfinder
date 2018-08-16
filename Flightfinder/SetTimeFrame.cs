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
    public partial class SetTimeFrame : Form
    { 
        public SetTimeFrame(Main incomingForm)
        {
            Mainform = incomingForm;
            InitializeComponent();
            DtpTimeframeTime.CustomFormat = DateTime.Now.ToString("HH:mm");
        }
        Main Mainform;
        private void DtpFlighttime_MouseDown(object sender, MouseEventArgs e)
        {
            DtpTimeframeTime.CustomFormat = "HH:mm";
        }

        private void BtnSetframe_Click(object sender, EventArgs e)
        {
            Mainform.timeframe = DtpTimeframeTime.Value.TimeOfDay.ToString();
            Mainform.Dateframe = DtpTimeframeDate.Value.Date.ToString("dd/MM/yyyy");
        }
    }
}
