using Hotel_Project.Views;
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
    public partial class Login : Form
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
            pictureBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 10, 10));
            pictureBox3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox3.Width, pictureBox3.Height, 10, 10));
            pictureBox4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox4.Width, pictureBox4.Height, 10, 10));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));

            placeHolderTextBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, placeHolderTextBox2.Width, placeHolderTextBox2.Height, 10, 10));
            placeHolderTextBox4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, placeHolderTextBox4.Width, placeHolderTextBox4.Height, 10, 10));

        }
        public Login()
        {
            InitializeComponent();
            BorderRaduis();
        }

        private void placeHolderTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prestation_or_Boocking prestation_or_Booking = new Prestation_or_Boocking();
            prestation_or_Booking.Show();
            this.Close();
        }
    }
}
