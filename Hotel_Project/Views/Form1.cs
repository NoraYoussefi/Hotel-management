using Hotel_Project.Views;
using System.Runtime.InteropServices;

namespace Hotel_Project

{
    public partial class Form1 : Form
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
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));

        }

        public Form1()
        {
            InitializeComponent();
            BorderRaduis();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                Hotels h = new Hotels();
                h.Show();
            
        }

        private void borderRaduis1_Click(object sender, EventArgs e)
        {
            adminDashboard a = new adminDashboard();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dashboard a = new dashboard();
            a.Show();
        }
    }
}