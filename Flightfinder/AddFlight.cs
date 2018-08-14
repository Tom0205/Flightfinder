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
    public partial class AddFlight : Form
    {
        public AddFlight()
        {
            InitializeComponent();
            DurationPicker.CustomFormat = DateTime.Now.ToString("HH:mm");
        }

        private void DurationPicker_MouseDown(object sender, MouseEventArgs e)
        {
            DurationPicker.CustomFormat = "HH:mm";
        }
    }
}
