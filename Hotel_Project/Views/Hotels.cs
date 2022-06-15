using Hotel_Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Project
{
    public partial class Hotels : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
       int nleft,
       int nTop,
       int nRight,
       int nBottom,
       int nWidthEllipse,
       int nHeightEllipse


       );

        private void BorderRaduis()
        {
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 10, 0));
            pictureBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox2.Width, pictureBox2.Height, 10, 0));
        }
        public Hotels()
        {
            InitializeComponent();
            BorderRaduis();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Hotels_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            /*UC.UcHotel ucHotel = new UC.UcHotel();*/
            List<Address> AllAddresses = db.Addresses.ToList();
            int y = 50;
            foreach (Address h in AllAddresses)
            {
                Panel panel6;
                panel6 = new System.Windows.Forms.Panel();

                panel6.BackColor = System.Drawing.Color.White;
                panel6.Location = new System.Drawing.Point(637, 141+y);
                panel6.Name = "panel6";
                panel6.Size = new System.Drawing.Size(300, 38);
                panel6.TabIndex = 9;



                this.panel1.Controls.Add(panel6);


                y = y + 50;
            }
        }
    }
}
