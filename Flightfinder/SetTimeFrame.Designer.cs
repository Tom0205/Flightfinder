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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetTimeFrame));
            this.BtnSetframe = new System.Windows.Forms.Button();
            this.DtpTimeframeTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BtnSetframe
            // 
            this.BtnSetframe.Location = new System.Drawing.Point(177, 55);
            this.BtnSetframe.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSetframe.Name = "BtnSetframe";
            this.BtnSetframe.Size = new System.Drawing.Size(64, 21);
            this.BtnSetframe.TabIndex = 0;
            this.BtnSetframe.Text = "Set time frame";
            this.BtnSetframe.UseVisualStyleBackColor = true;
            this.BtnSetframe.Click += new System.EventHandler(this.BtnSetframe_Click);
            // 
            // DtpTimeframeTime
            // 
            this.DtpTimeframeTime.CustomFormat = "00:00";
            this.DtpTimeframeTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTimeframeTime.Location = new System.Drawing.Point(22, 55);
            this.DtpTimeframeTime.Margin = new System.Windows.Forms.Padding(2);
            this.DtpTimeframeTime.Name = "DtpTimeframeTime";
            this.DtpTimeframeTime.ShowUpDown = true;
            this.DtpTimeframeTime.Size = new System.Drawing.Size(151, 20);
            this.DtpTimeframeTime.TabIndex = 5;
            // 
            // SetTimeFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 87);
            this.Controls.Add(this.DtpTimeframeTime);
            this.Controls.Add(this.BtnSetframe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SetTimeFrame";
            this.Text = "SetTimeFrame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSetframe;
        private System.Windows.Forms.DateTimePicker DtpTimeframeTime;
    }
}