namespace Flightfinder
{
    partial class FlightInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightInfo));
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRegistration = new System.Windows.Forms.TextBox();
            this.TxtCallsign = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtArrival = new System.Windows.Forms.TextBox();
            this.DtpFlighttime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDeparture = new System.Windows.Forms.TextBox();
            this.BtnVerwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Registration";
            // 
            // TxtRegistration
            // 
            this.TxtRegistration.Enabled = false;
            this.TxtRegistration.Location = new System.Drawing.Point(81, 79);
            this.TxtRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRegistration.Name = "TxtRegistration";
            this.TxtRegistration.Size = new System.Drawing.Size(76, 20);
            this.TxtRegistration.TabIndex = 19;
            // 
            // TxtCallsign
            // 
            this.TxtCallsign.Enabled = false;
            this.TxtCallsign.Location = new System.Drawing.Point(81, 56);
            this.TxtCallsign.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCallsign.Name = "TxtCallsign";
            this.TxtCallsign.Size = new System.Drawing.Size(76, 20);
            this.TxtCallsign.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Callsign";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Flight time";
            // 
            // TxtArrival
            // 
            this.TxtArrival.Enabled = false;
            this.TxtArrival.Location = new System.Drawing.Point(81, 33);
            this.TxtArrival.Margin = new System.Windows.Forms.Padding(2);
            this.TxtArrival.Name = "TxtArrival";
            this.TxtArrival.Size = new System.Drawing.Size(76, 20);
            this.TxtArrival.TabIndex = 15;
            // 
            // DtpFlighttime
            // 
            this.DtpFlighttime.CustomFormat = "00:00";
            this.DtpFlighttime.Enabled = false;
            this.DtpFlighttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFlighttime.Location = new System.Drawing.Point(81, 102);
            this.DtpFlighttime.Margin = new System.Windows.Forms.Padding(2);
            this.DtpFlighttime.Name = "DtpFlighttime";
            this.DtpFlighttime.ShowUpDown = true;
            this.DtpFlighttime.Size = new System.Drawing.Size(76, 20);
            this.DtpFlighttime.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Arrival";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Departure";
            // 
            // TxtDeparture
            // 
            this.TxtDeparture.Enabled = false;
            this.TxtDeparture.Location = new System.Drawing.Point(81, 11);
            this.TxtDeparture.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDeparture.Name = "TxtDeparture";
            this.TxtDeparture.Size = new System.Drawing.Size(76, 20);
            this.TxtDeparture.TabIndex = 11;
            // 
            // BtnVerwijder
            // 
            this.BtnVerwijder.Location = new System.Drawing.Point(134, 126);
            this.BtnVerwijder.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVerwijder.Name = "BtnVerwijder";
            this.BtnVerwijder.Size = new System.Drawing.Size(62, 19);
            this.BtnVerwijder.TabIndex = 21;
            this.BtnVerwijder.Text = "Verwijder";
            this.BtnVerwijder.UseVisualStyleBackColor = true;
            this.BtnVerwijder.Click += new System.EventHandler(this.BtnVerwijder_Click);
            // 
            // FlightInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 154);
            this.Controls.Add(this.BtnVerwijder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtRegistration);
            this.Controls.Add(this.TxtCallsign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtArrival);
            this.Controls.Add(this.DtpFlighttime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDeparture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FlightInfo";
            this.Text = "FlightInfo";
            this.Load += new System.EventHandler(this.FlightInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRegistration;
        private System.Windows.Forms.TextBox TxtCallsign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtArrival;
        private System.Windows.Forms.DateTimePicker DtpFlighttime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDeparture;
        private System.Windows.Forms.Button BtnVerwijder;
    }
}