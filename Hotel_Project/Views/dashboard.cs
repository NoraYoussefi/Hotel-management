using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Project.Views
{
    public partial class dashboard : Form
    {
        /*public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }*/

        //Fields
        private Button currentButton;
        private Form activeForm;
        public dashboard()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
        }



        private void dashboard_Load(object sender, EventArgs e)
        {
            //btn_show.Visible = false;

        }

        //guna2Panel1.Visible = false;
        //btn_hide.Visible = false;
        //btn_show.Visible = true;
        //guna2Panel1.Width = 55;
        //guna2Transition1.ShowSync(guna2Panel1);

        //btn_show.Visible = false;
        //btn_hide.Visible = true;
        //guna2Panel1.Visible = false;
        //guna2Panel1.Width = 288;
        //guna2Transition1.ShowSync(guna2Panel1);

        //Methods
        private Color SelectThemeColor()
        {
            return ColorTranslator.FromHtml("#FFFFFF");
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(93, 69, 77);
                    previousBtn.ForeColor = Color.White;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            btnCloseChildForm.Visible = true;
        }

        private void OpenChildForm_1(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            btnCloseChildForm.Visible = true;
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(93, 69, 77);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UnderDashboard.users(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UnderDashboard.rooms(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UnderDashboard.categories(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UnderDashboard.reservations(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UnderDashboard.clients(), sender);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UnderDashboard.hotels(), sender);
        }

        /* private void button6_Click(object sender, EventArgs e)
         {
             OpenChildForm(new Forms.consumptions(), sender);
         }

         private void button7_Click(object sender, EventArgs e)
         {
             OpenChildForm(new Forms.bills(), sender);
         }

         private void button8_Click(object sender, EventArgs e)
         {
             OpenChildForm(new Forms.checkout(), sender);
         }*/

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 homePage = new Form1();
            this.Hide();
            homePage.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new UnderDashboard.rooms(), sender);
        }

       /* private void roundedButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new UnderDashboard.bills(), sender);
        }

        private void roundedButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new Forms.checkout(), sender);
        }*/

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new UnderDashboard.clients(), sender);
        }
        private void roundedButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new UnderDashboard.hotels(), sender);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new UnderDashboard.users(), sender);
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new UnderDashboard.categories(), sender);
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new UnderDashboard.reservations(), sender);
        }

        /*private void roundedButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm_1(new Forms.consumptions(), sender);
        }*/

        private void button11_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new UnderDashboard.hotels(), sender);
        }

        private void borderRaduis1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
