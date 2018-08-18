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
            this.BtnFlight = new System.Windows.Forms.Button();
            this.BtnTime = new System.Windows.Forms.Button();
            this.LstPossible = new System.Windows.Forms.ListBox();
            this.LblTimeframe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnFlight
            // 
            this.BtnFlight.Location = new System.Drawing.Point(205, 12);
            this.BtnFlight.Name = "BtnFlight";
            this.BtnFlight.Size = new System.Drawing.Size(106, 23);
            this.BtnFlight.TabIndex = 0;
            this.BtnFlight.Text = "Add Flight";
            this.BtnFlight.UseVisualStyleBackColor = true;
            this.BtnFlight.Click += new System.EventHandler(this.BtnFlight_Click);
            // 
            // BtnTime
            // 
            this.BtnTime.Location = new System.Drawing.Point(12, 12);
            this.BtnTime.Name = "BtnTime";
            this.BtnTime.Size = new System.Drawing.Size(106, 23);
            this.BtnTime.TabIndex = 1;
            this.BtnTime.Text = "Set timeframe";
            this.BtnTime.UseVisualStyleBackColor = true;
            this.BtnTime.Click += new System.EventHandler(this.BtnTime_Click);
            // 
            // LstPossible
            // 
            this.LstPossible.FormattingEnabled = true;
            this.LstPossible.ItemHeight = 16;
            this.LstPossible.Location = new System.Drawing.Point(12, 41);
            this.LstPossible.Name = "LstPossible";
            this.LstPossible.Size = new System.Drawing.Size(299, 340);
            this.LstPossible.TabIndex = 2;
            this.LstPossible.DoubleClick += new System.EventHandler(this.LstPossible_DoubleClick);
            // 
            // LblTimeframe
            // 
            this.LblTimeframe.AutoSize = true;
            this.LblTimeframe.Location = new System.Drawing.Point(9, 384);
            this.LblTimeframe.Name = "LblTimeframe";
            this.LblTimeframe.Size = new System.Drawing.Size(152, 17);
            this.LblTimeframe.TabIndex = 4;
            this.LblTimeframe.Text = "Current set timeframe: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 421);
            this.Controls.Add(this.LblTimeframe);
            this.Controls.Add(this.LstPossible);
            this.Controls.Add(this.BtnTime);
            this.Controls.Add(this.BtnFlight);
            this.Name = "Main";
            this.Text = "Main";
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

