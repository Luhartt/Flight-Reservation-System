using System.Drawing;
using System.Windows.Forms;

namespace Flight_Reservation_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.button2 = new System.Windows.Forms.Button();
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.btnFlightBooking = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.Indicator = new System.Windows.Forms.Panel();
            this.pnlIndicator = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPageName = new System.Windows.Forms.Label();
            this.Indicator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(743, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBookings.ForeColor = System.Drawing.Color.Black;
            this.btnViewBookings.Image = ((System.Drawing.Image)(resources.GetObject("btnViewBookings.Image")));
            this.btnViewBookings.Location = new System.Drawing.Point(1, 508);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(315, 187);
            this.btnViewBookings.TabIndex = 2;
            this.btnViewBookings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewBookings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewBookings.UseVisualStyleBackColor = true;
            // 
            // btnFlightBooking
            // 
            this.btnFlightBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlightBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnFlightBooking.Image")));
            this.btnFlightBooking.Location = new System.Drawing.Point(1, 325);
            this.btnFlightBooking.Name = "btnFlightBooking";
            this.btnFlightBooking.Size = new System.Drawing.Size(315, 187);
            this.btnFlightBooking.TabIndex = 3;
            this.btnFlightBooking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFlightBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFlightBooking.UseVisualStyleBackColor = true;
            this.btnFlightBooking.Click += new System.EventHandler(this.btnFlightBooking_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(1, 142);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(315, 187);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.Location = new System.Drawing.Point(1, 692);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(315, 187);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // Indicator
            // 
            this.Indicator.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Indicator.Controls.Add(this.pnlIndicator);
            this.Indicator.Location = new System.Drawing.Point(306, 142);
            this.Indicator.Name = "Indicator";
            this.Indicator.Size = new System.Drawing.Size(10, 187);
            this.Indicator.TabIndex = 6;
            // 
            // pnlIndicator
            // 
            this.pnlIndicator.BackColor = System.Drawing.Color.Transparent;
            this.pnlIndicator.Location = new System.Drawing.Point(0, 0);
            this.pnlIndicator.Name = "pnlIndicator";
            this.pnlIndicator.Size = new System.Drawing.Size(10, 187);
            this.pnlIndicator.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.lblPageName);
            this.Header.Controls.Add(this.btnLogout);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Location = new System.Drawing.Point(1, -2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1302, 147);
            this.Header.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1055, 46);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(207, 54);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = " ";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblPageName
            // 
            this.lblPageName.Location = new System.Drawing.Point(366, 4);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(683, 134);
            this.lblPageName.TabIndex = 9;
            this.lblPageName.Text = "label1";
            this.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPageName.Click += new System.EventHandler(this.lblPageName_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1301, 876);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Indicator);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnFlightBooking);
            this.Controls.Add(this.btnViewBookings);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Indicator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnViewBookings;
        private System.Windows.Forms.Button btnFlightBooking;
        private System.Windows.Forms.Button btnDashboard;
        private Button btnProfile;
        private Panel Indicator;
        private PictureBox pictureBox1;
        private Panel Header;
        private Button btnLogout;
        private Panel pnlIndicator;
        private Label lblPageName;
    }
}

