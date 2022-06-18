using Hotel_Project.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
     
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {
            Database db = new Database();
          /*  List<Address> AllAddresses = db.Addresses.ToList();
            dataGridView1.DataSource = db.Addresses.ToList();
       */   /*  List<Hotel> AllHotels = db.Hotels.ToList();
            dataGridView1.DataSource = db.Hotels.ToList();
*/
            /*foreach (Address address in AllAddresses)
            {
                
               *//* System.Windows.Forms.TableLayoutPanel tbl_Panel = new System.Windows.Forms.TableLayoutPanel();
                System.Windows.Forms.TableLayoutPanel id_Panel = new System.Windows.Forms.TableLayoutPanel();
*//*
            }*/
            /* Database db = new Database();
             List<Hotel> AllHotels = db.Hotels.ToList();
             foreach (Hotel h in AllHotels)
             {

                 Label lbl = new Label();
                 lbl.Text = "HHH";
                 lbl.Height = 12;
                 lbl.Width = 12;
                 lbl.BackColor = Color.Red;
                 lbl.Visible = true;


                 flowLayoutPanel1.Controls.Add(lbl);
             }*/
            /* Database db = new Database();
             List<Address> AllAddresses = db.Addresses.ToList();
             foreach (Address h in AllAddresses)
             {

                 Label lbl = new Label();
                 lbl.Text = "HHH";
                 lbl.Height = 12;
                 lbl.Width = 12;
                 lbl.BackColor = Color.Red;
                 lbl.Visible = true;


                 flowLayoutPanel1.Controls.Add(lbl);
             }*/


            /*List<Address> AllAddresses = db.Addresses.ToList();
            int y = 54;
            foreach (Address h in AllAddresses)
            {
                Panel panel1;
                panel1 = new System.Windows.Forms.Panel();
                Label Id;
                Id = new System.Windows.Forms.Label();

                panel1.BackColor = System.Drawing.Color.White;
                panel1.Location = new System.Drawing.Point(44, 57+y);
                panel1.Name = "panel1";
                panel1.Size = new System.Drawing.Size(847, 51);
                panel1.TabIndex = 0;
                panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);


                Id.AutoSize = true;
                Id.Location = new System.Drawing.Point(9, 14);
                Id.Name = "Id";
                Id.Size = new System.Drawing.Size(28, 25);
                Id.TabIndex = 10;
                Id.Text = h.Id.ToString();
                Id.Click += new System.EventHandler(this.Id_Click);


                this.tabPage1.Controls.Add(panel1);
                tabPage1.Controls.Add(Id);


                y = y + 54;
            }*/
            List<Hotel> AllHotels = db.Hotels.ToList();
            int y = 54;
            foreach (Hotel h in AllHotels)
            {
                /*Panel panel1;
                panel1 = new System.Windows.Forms.Panel();
                Label Id_hotel;
                Id_hotel = new System.Windows.Forms.Label();

                panel1.BackColor = System.Drawing.Color.White;
                panel1.Location = new System.Drawing.Point(44, 57 + y);
                panel1.Name = "panel1";
                panel1.Size = new System.Drawing.Size(847, 51);
                panel1.TabIndex = 0;
                panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);


                Id_hotel.AutoSize = true;
                Id_hotel.Location = new System.Drawing.Point(9, 14);
                Id_hotel.Name = "Id_hotel";
                Id_hotel.Size = new System.Drawing.Size(28, 25);
                Id_hotel.TabIndex = 10;
                Id_hotel.Text = h.Id.ToString();
                Id_hotel.BringToFront();
*//*                Id_hotel.Click += new System.EventHandler(this.Id_Click);
*//*

                this.tabPage1.Controls.Add(panel1);
                tabPage1.Controls.Add(Id_hotel);
*/
               /* Label test;
                test = new System.Windows.Forms.Label();

                test.AutoSize = true;
                test.Location = new System.Drawing.Point(193, 204+y);
                test.Name = "test";
                test.Size = new System.Drawing.Size(59, 25);
                test.TabIndex = 1;
                test.Text = h.Name;
                test.Click += new System.EventHandler(this.test_Click);

                this.Controls.Add(test);

                y = y + 54;*/
            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            /*Database db = new Database();
            List<Hotel> AllHotels = db.Hotels.ToList();
            foreach (Hotel h in AllHotels)
            {
                System.Windows.Forms.TableLayoutPanel tbl_Panel = new System.Windows.Forms.TableLayoutPanel();

            }*/



        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void stars_Click(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void category_Click(object sender, EventArgs e)
        {

        }

        private void rooms_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
