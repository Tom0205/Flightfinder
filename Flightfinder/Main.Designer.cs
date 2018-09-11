namespace Flightfinder
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BtnFlight = new System.Windows.Forms.Button();
            this.BtnTime = new System.Windows.Forms.Button();
            this.LstPossible = new System.Windows.Forms.ListBox();
            this.LblTimeframe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnFlight
            // 
            this.BtnFlight.Location = new System.Drawing.Point(157, 33);
            this.BtnFlight.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFlight.Name = "BtnFlight";
            this.BtnFlight.Size = new System.Drawing.Size(80, 19);
            this.BtnFlight.TabIndex = 0;
            this.BtnFlight.Text = "Add Flight";
            this.BtnFlight.UseVisualStyleBackColor = true;
            this.BtnFlight.Click += new System.EventHandler(this.BtnFlight_Click);
            // 
            // BtnTime
            // 
            this.BtnTime.Location = new System.Drawing.Point(22, 33);
            this.BtnTime.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTime.Name = "BtnTime";
            this.BtnTime.Size = new System.Drawing.Size(80, 19);
            this.BtnTime.TabIndex = 1;
            this.BtnTime.Text = "Set timeframe";
            this.BtnTime.UseVisualStyleBackColor = true;
            this.BtnTime.Click += new System.EventHandler(this.BtnTime_Click);
            // 
            // LstPossible
            // 
            this.LstPossible.FormattingEnabled = true;
            this.LstPossible.Location = new System.Drawing.Point(22, 65);
            this.LstPossible.Margin = new System.Windows.Forms.Padding(2);
            this.LstPossible.Name = "LstPossible";
            this.LstPossible.Size = new System.Drawing.Size(215, 277);
            this.LstPossible.TabIndex = 2;
            this.LstPossible.DoubleClick += new System.EventHandler(this.LstPossible_DoubleClick);
            // 
            // LblTimeframe
            // 
            this.LblTimeframe.AutoSize = true;
            this.LblTimeframe.Location = new System.Drawing.Point(22, 351);
            this.LblTimeframe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTimeframe.Name = "LblTimeframe";
            this.LblTimeframe.Size = new System.Drawing.Size(112, 13);
            this.LblTimeframe.TabIndex = 4;
            this.LblTimeframe.Text = "Current set timeframe: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 374);
            this.Controls.Add(this.LblTimeframe);
            this.Controls.Add(this.LstPossible);
            this.Controls.Add(this.BtnTime);
            this.Controls.Add(this.BtnFlight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFlight;
        private System.Windows.Forms.Button BtnTime;
        private System.Windows.Forms.ListBox LstPossible;
        private System.Windows.Forms.Label LblTimeframe;
    }
}

