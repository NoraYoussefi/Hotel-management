using Hotel_Project.Data;
using Hotel_Project.Properties;
using Microsoft.EntityFrameworkCore;
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
          /*  panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 10, 0));
            pictureBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox2.Width, pictureBox2.Height, 10, 0));
      */  }
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
/*            this.AutoScroll = true;
 *            
*/            Database db = new Database();
            List<Hotel> AllHotels = db.Hotels.Include(c => c.Cassement).Include(a => a.Address).ToList();
            this.panel1.Size = new System.Drawing.Size(1200+(AllHotels.Count -3)* 304, 686);

            /*UC.UcHotel ucHotel = new UC.UcHotel();*/
            /*if (i > 2)
            {
                int size = 1200;
                size += (400 * i);
                this.panel1.Size = new System.Drawing.Size(size, 686);
                MessageBox.Show(size.ToString());

            }*/
           
            int x = 0;
            for (int i=0;i<AllHotels.Count ; i++)
            {
                Hotel h = AllHotels[i];
                

                Panel panel5;
               /* Panel panel1;*/
                /*  PictureBox pictureBox3;*/
                Button button1;
                Label label2;
                Label label3;
                PictureBox pictureBox2;
               
                pictureBox2 = new System.Windows.Forms.PictureBox();
                panel5 = new System.Windows.Forms.Panel();
/*                panel1 = new System.Windows.Forms.Panel();
*/                /*                pictureBox3 = new System.Windows.Forms.PictureBox();
                */
                button1 = new System.Windows.Forms.Button();
                label2 = new System.Windows.Forms.Label();
                label3 = new System.Windows.Forms.Label();

                panel1.SuspendLayout();
                panel5.SuspendLayout();

                this.SuspendLayout();
                /*
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
                panel5.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();*/
                this.SuspendLayout();


                // 
                // pictureBox2
                // 
                pictureBox2.Image = global::Hotel_Project.Properties.Resources.hotel1;
                pictureBox2.Location = new System.Drawing.Point(0,0);
                pictureBox2.Name = "pictureBox2";
                pictureBox2.Size = new System.Drawing.Size(304, 179);
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.TabIndex = 3;
                pictureBox2.TabStop = false;
                pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
                // 
                // pictureBox3
                // 
/*                pictureBox3.Name = h.Cassement.Rate.ToString();
*/                int c = Int32.Parse(h.Cassement.Rate.ToString());
                int s = 0;
                for (int j = 1; j <= c; j++)
                {
                    PictureBox pictureBox3 = new System.Windows.Forms.PictureBox();

                    pictureBox3.Location = new System.Drawing.Point(160 + s, 191);
                    pictureBox3.Image = global::Hotel_Project.Properties.Resources.star__1_;
                    pictureBox3.Name = "pictureBox3";
                    pictureBox3.Size = new System.Drawing.Size(30, 30);
                    pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    pictureBox3.TabIndex = 3;
                    pictureBox3.TabStop = false;
                    pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Click);
                    panel5.Controls.Add(pictureBox3);
                    s = s+31;
                    
                }
                
                // 
                // panel5
                // 
                panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                panel5.Location = new System.Drawing.Point(60 + x, 151);
                panel5.Name = "panel5";
                panel5.Size = new System.Drawing.Size(304, 387);
                panel5.TabIndex = 2;
                panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
                panel5.SendToBack();
                // 
                // label2
                // 
                label2.AutoSize = true;
                label2.Location = new System.Drawing.Point(41, 226);
                label2.Name = "label2";
                label2.Size = new System.Drawing.Size(141, 25);
                label2.TabIndex = 3;
                label2.Text = h.Name.ToString();
                // 
                // label3
                // 
                label3.Location = new System.Drawing.Point(41, 266);
                label3.Name = "label3";
                label3.Size = new System.Drawing.Size(242, 74);
                label3.TabIndex = 3;
                label3.Text = h.Name.ToString();
                // 
                // button1
                // 
                button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
                button1.FlatAppearance.BorderSize = 0;
                button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                button1.Location = new System.Drawing.Point(102, 334);
                button1.Name = "button1";
                button1.Size = new System.Drawing.Size(112, 34);
                button1.TabIndex = 2;
                button1.Text = "see more";
                button1.UseVisualStyleBackColor = false;
                // 
                // panel1
                // 
              /*  panel1.BackgroundImage = global::Hotel_Project.Properties.Resources.bgfigma1;
         
                panel1.Location = new System.Drawing.Point(0, -3);
                panel1.Name = "panel1";
                panel1.Size = new System.Drawing.Size(1132, 635);
                panel1.TabIndex = 1;
*/

                panel5.Controls.Add(pictureBox2);
/*                panel5.Controls.Add(pictureBox3);
*/              panel5.Controls.Add(button1);
                panel5.Controls.Add(label2);
                panel5.Controls.Add(label3);
                panel1.Controls.Add(panel5);
/*                this.Controls.Add(panel5);
*/


                x = x + 350;
                panel5.ResumeLayout(false);
                panel5.PerformLayout();
              
               
                /*this.SetAutoScrollMargins();*/
                /*this.Controls.Clear();*/
                /*                this.AutoScroll = false;
                */               /* this.VerticalScroll.Enabled = true;
                                this.VerticalScroll.Visible = true;*/

                /*this.HorizontalScroll.Enabled = true;
                this.HorizontalScroll.Visible = true;
*/
                /*this.AutoScroll = true;*/
            }
        }
        private void SetAutoScrollMargins()
        {
            Panel panel5 = new System.Windows.Forms.Panel();
            /* If the text box is outside the panel's bounds, 
               turn on auto-scrolling and set the margin. */
            if (panel5.Location.X > 1154 ||
               panel5.Location.Y > 686)
            {
                panel5.AutoScroll = true;
                /* If the AutoScrollMargin is set to less 
                   than (5,5), set it to 5,5. */
                if (panel5.AutoScrollMargin.Width < 5 ||
                   panel5.AutoScrollMargin.Height < 5)
                {
                    panel5.SetAutoScrollMargin(5, 5);
                }
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
