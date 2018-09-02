namespace Flightfinder
{
    partial class AddFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFlight));
            this.TxtDeparture = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFlighttime = new System.Windows.Forms.DateTimePicker();
            this.TxtArrival = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCallsign = new System.Windows.Forms.TextBox();
            this.TxtRegistration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDeparture
            // 
            this.TxtDeparture.Location = new System.Drawing.Point(77, 10);
            this.TxtDeparture.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDeparture.Name = "TxtDeparture";
            this.TxtDeparture.Size = new System.Drawing.Size(76, 20);
            this.TxtDeparture.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(146, 177);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(56, 19);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arrival";
            // 
            // DtpFlighttime
            // 
            this.DtpFlighttime.CustomFormat = "00:00";
            this.DtpFlighttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFlighttime.Location = new System.Drawing.Point(77, 101);
            this.DtpFlighttime.Margin = new System.Windows.Forms.Padding(2);
            this.DtpFlighttime.Name = "DtpFlighttime";
            this.DtpFlighttime.ShowUpDown = true;
            this.DtpFlighttime.Size = new System.Drawing.Size(76, 20);
            this.DtpFlighttime.TabIndex = 4;
            this.DtpFlighttime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DtpFlighttime_MouseDown);
            // 
            // TxtArrival
            // 
            this.TxtArrival.Location = new System.Drawing.Point(77, 32);
            this.TxtArrival.Margin = new System.Windows.Forms.Padding(2);
            this.TxtArrival.Name = "TxtArrival";
            this.TxtArrival.Size = new System.Drawing.Size(76, 20);
            this.TxtArrival.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Flight time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Callsign";
            // 
            // TxtCallsign
            // 
            this.TxtCallsign.Location = new System.Drawing.Point(77, 55);
            this.TxtCallsign.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCallsign.Name = "TxtCallsign";
            this.TxtCallsign.Size = new System.Drawing.Size(76, 20);
            this.TxtCallsign.TabIndex = 8;
            // 
            // TxtRegistration
            // 
            this.TxtRegistration.Location = new System.Drawing.Point(77, 78);
            this.TxtRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRegistration.Name = "TxtRegistration";
            this.TxtRegistration.Size = new System.Drawing.Size(76, 20);
            this.TxtRegistration.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registration";
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 206);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtRegistration);
            this.Controls.Add(this.TxtCallsign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtArrival);
            this.Controls.Add(this.DtpFlighttime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtDeparture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddFlight";
            this.Text = "AddFlight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFlight_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDeparture;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFlighttime;
        private System.Windows.Forms.TextBox TxtArrival;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCallsign;
        private System.Windows.Forms.TextBox TxtRegistration;
        private System.Windows.Forms.Label label5;
    }
}