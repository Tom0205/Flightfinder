namespace Flightfinder
{
    partial class SetTimeFrame
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
            this.BtnSetframe = new System.Windows.Forms.Button();
            this.DtpTimeframeDate = new System.Windows.Forms.DateTimePicker();
            this.DtpTimeframeTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BtnSetframe
            // 
            this.BtnSetframe.Location = new System.Drawing.Point(233, 19);
            this.BtnSetframe.Name = "BtnSetframe";
            this.BtnSetframe.Size = new System.Drawing.Size(69, 50);
            this.BtnSetframe.TabIndex = 0;
            this.BtnSetframe.Text = "Set time frame";
            this.BtnSetframe.UseVisualStyleBackColor = true;
            this.BtnSetframe.Click += new System.EventHandler(this.BtnSetframe_Click);
            // 
            // DtpTimeframeDate
            // 
            this.DtpTimeframeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTimeframeDate.Location = new System.Drawing.Point(27, 47);
            this.DtpTimeframeDate.Name = "DtpTimeframeDate";
            this.DtpTimeframeDate.Size = new System.Drawing.Size(200, 22);
            this.DtpTimeframeDate.TabIndex = 2;
            // 
            // DtpTimeframeTime
            // 
            this.DtpTimeframeTime.CustomFormat = "00:00";
            this.DtpTimeframeTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTimeframeTime.Location = new System.Drawing.Point(27, 19);
            this.DtpTimeframeTime.Name = "DtpTimeframeTime";
            this.DtpTimeframeTime.ShowUpDown = true;
            this.DtpTimeframeTime.Size = new System.Drawing.Size(200, 22);
            this.DtpTimeframeTime.TabIndex = 5;
            this.DtpTimeframeTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DtpFlighttime_MouseDown);
            // 
            // SetTimeFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 88);
            this.Controls.Add(this.DtpTimeframeTime);
            this.Controls.Add(this.DtpTimeframeDate);
            this.Controls.Add(this.BtnSetframe);
            this.Name = "SetTimeFrame";
            this.Text = "SetTimeFrame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSetframe;
        private System.Windows.Forms.DateTimePicker DtpTimeframeDate;
        private System.Windows.Forms.DateTimePicker DtpTimeframeTime;
    }
}