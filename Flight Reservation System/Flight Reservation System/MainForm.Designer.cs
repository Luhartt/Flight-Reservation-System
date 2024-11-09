﻿using System.Drawing;
using System.Windows.Forms;

namespace Flight_Reservation_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.lblPageName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlIndicator1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlIndicator4 = new System.Windows.Forms.Panel();
            this.pnlIndicator3 = new System.Windows.Forms.Panel();
            this.pnlIndicator2 = new System.Windows.Forms.Panel();
            this.btnFlightBooking = new System.Windows.Forms.Button();
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
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
            // lblPageName
            // 
            this.lblPageName.Location = new System.Drawing.Point(366, 4);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(683, 134);
            this.lblPageName.TabIndex = 9;
            this.lblPageName.Text = "label1";
            this.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1055, 44);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(207, 54);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = " ";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // pnlIndicator1
            // 
            this.pnlIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.pnlIndicator1.Location = new System.Drawing.Point(306, 142);
            this.pnlIndicator1.Name = "pnlIndicator1";
            this.pnlIndicator1.Size = new System.Drawing.Size(10, 187);
            this.pnlIndicator1.TabIndex = 32;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(1, 142);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(315, 187);
            this.btnDashboard.TabIndex = 31;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlIndicator4
            // 
            this.pnlIndicator4.BackColor = System.Drawing.Color.Transparent;
            this.pnlIndicator4.Location = new System.Drawing.Point(306, 696);
            this.pnlIndicator4.Name = "pnlIndicator4";
            this.pnlIndicator4.Size = new System.Drawing.Size(10, 187);
            this.pnlIndicator4.TabIndex = 30;
            // 
            // pnlIndicator3
            // 
            this.pnlIndicator3.BackColor = System.Drawing.Color.Transparent;
            this.pnlIndicator3.Location = new System.Drawing.Point(306, 514);
            this.pnlIndicator3.Name = "pnlIndicator3";
            this.pnlIndicator3.Size = new System.Drawing.Size(10, 187);
            this.pnlIndicator3.TabIndex = 29;
            // 
            // pnlIndicator2
            // 
            this.pnlIndicator2.BackColor = System.Drawing.Color.Transparent;
            this.pnlIndicator2.Location = new System.Drawing.Point(306, 329);
            this.pnlIndicator2.Name = "pnlIndicator2";
            this.pnlIndicator2.Size = new System.Drawing.Size(10, 187);
            this.pnlIndicator2.TabIndex = 25;
            // 
            // btnFlightBooking
            // 
            this.btnFlightBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlightBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnFlightBooking.Image")));
            this.btnFlightBooking.Location = new System.Drawing.Point(1, 328);
            this.btnFlightBooking.Name = "btnFlightBooking";
            this.btnFlightBooking.Size = new System.Drawing.Size(315, 187);
            this.btnFlightBooking.TabIndex = 27;
            this.btnFlightBooking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFlightBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFlightBooking.UseVisualStyleBackColor = true;
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBookings.ForeColor = System.Drawing.Color.Black;
            this.btnViewBookings.Image = ((System.Drawing.Image)(resources.GetObject("btnViewBookings.Image")));
            this.btnViewBookings.Location = new System.Drawing.Point(1, 511);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(315, 187);
            this.btnViewBookings.TabIndex = 26;
            this.btnViewBookings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewBookings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewBookings.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.Location = new System.Drawing.Point(1, 695);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(315, 187);
            this.btnProfile.TabIndex = 28;
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1301, 876);
            this.Controls.Add(this.pnlIndicator1);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.pnlIndicator4);
            this.Controls.Add(this.pnlIndicator3);
            this.Controls.Add(this.pnlIndicator2);
            this.Controls.Add(this.btnFlightBooking);
            this.Controls.Add(this.btnViewBookings);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private Panel Header;
        private Button btnLogout;
        private Label lblPageName;
        internal Panel pnlIndicator1;
        internal Button btnDashboard;
        internal Panel pnlIndicator4;
        internal Panel pnlIndicator3;
        internal Panel pnlIndicator2;
        internal Button btnFlightBooking;
        internal Button btnViewBookings;
        internal Button btnProfile;
    }
}
