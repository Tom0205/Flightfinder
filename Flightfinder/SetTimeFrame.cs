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
    public partial class SetTimeFrame : MetroFramework.Forms.MetroForm
    { 
        public SetTimeFrame(Main incomingForm)
        {
            Mainform = incomingForm;
            InitializeComponent();
            DtpTimeframeTime.Format = DateTimePickerFormat.Custom;
            DtpTimeframeTime.CustomFormat = "dd/MM/yyyy HH:mm";
        }
        Main Mainform;
        private void BtnSetframe_Click(object sender, EventArgs e)
        {
            //here the timeframe will be set to the variable and the 2 needed function will be called
            Mainform.timeframe = DtpTimeframeTime.Value;
            Mainform.PopulateLabel();
            Mainform.SearchFlights();
            this.Close();
        }
    }
}
