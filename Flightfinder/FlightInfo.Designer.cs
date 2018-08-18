﻿namespace Flightfinder
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
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Registration";
            // 
            // TxtRegistration
            // 
            this.TxtRegistration.Enabled = false;
            this.TxtRegistration.Location = new System.Drawing.Point(108, 97);
            this.TxtRegistration.Name = "TxtRegistration";
            this.TxtRegistration.Size = new System.Drawing.Size(100, 22);
            this.TxtRegistration.TabIndex = 19;
            // 
            // TxtCallsign
            // 
            this.TxtCallsign.Enabled = false;
            this.TxtCallsign.Location = new System.Drawing.Point(108, 69);
            this.TxtCallsign.Name = "TxtCallsign";
            this.TxtCallsign.Size = new System.Drawing.Size(100, 22);
            this.TxtCallsign.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Callsign";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Flight time";
            // 
            // TxtArrival
            // 
            this.TxtArrival.Enabled = false;
            this.TxtArrival.Location = new System.Drawing.Point(108, 41);
            this.TxtArrival.Name = "TxtArrival";
            this.TxtArrival.Size = new System.Drawing.Size(100, 22);
            this.TxtArrival.TabIndex = 15;
            // 
            // DtpFlighttime
            // 
            this.DtpFlighttime.CustomFormat = "00:00";
            this.DtpFlighttime.Enabled = false;
            this.DtpFlighttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFlighttime.Location = new System.Drawing.Point(108, 125);
            this.DtpFlighttime.Name = "DtpFlighttime";
            this.DtpFlighttime.ShowUpDown = true;
            this.DtpFlighttime.Size = new System.Drawing.Size(100, 22);
            this.DtpFlighttime.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Arrival";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Departure";
            // 
            // TxtDeparture
            // 
            this.TxtDeparture.Enabled = false;
            this.TxtDeparture.Location = new System.Drawing.Point(108, 13);
            this.TxtDeparture.Name = "TxtDeparture";
            this.TxtDeparture.Size = new System.Drawing.Size(100, 22);
            this.TxtDeparture.TabIndex = 11;
            // 
            // FlightInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 165);
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
    }
}