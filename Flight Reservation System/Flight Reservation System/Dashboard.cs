using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Flight_Reservation_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            
            InitializeComponent();
           
        }

        //idk what does this do copied from stackoverflow
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        public Font KantumruyBold()
        {
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            byte[] fontData = Properties.Resources.KantumruyPro_Bold;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            privateFontCollection.AddMemoryFont(fontPtr, Properties.Resources.KantumruyPro_Bold.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.KantumruyPro_Bold.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return new Font(privateFontCollection.Families[0], 30.0F);
        }

        public void setHeader()
        {
            lblPageName.Text = "Dashboard".ToUpper();
            lblPageName.Font = KantumruyBold(); //set font from the copied code :>
            lblPageName.ForeColor = ColorTranslator.FromHtml("#5C5C5C");
            setIndicator();

        }

        public void setIndicator()
        {
  
            pnlIndicator.BackColor = ColorTranslator.FromHtml("#A780F4");
            btnDashboard.BackColor = ColorTranslator.FromHtml("#F4F3FF");
        }

        public void setButtonBorders()
        {

            Button[] btns = { btnDashboard, btnFlightBooking, btnViewBookings, btnProfile, btnLogout };

            foreach (Button btn in btns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.White;
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            String formColor = "#E6E9F0";
            this.BackColor = ColorTranslator.FromHtml(formColor);
            Header.BackColor = Color.White;
            setButtonBorders();
            setHeader();


        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnFlightBooking_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPageName_Click(object sender, EventArgs e)
        {

        }
    }
}
