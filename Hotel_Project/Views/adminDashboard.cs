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
            /*      *//*      List<Address> AllAddresses = db.Addresses.ToList();
            *//*            dataGridView1.DataSource = db.Addresses.ToList();*/
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
            Database db = new Database();
            /*UC.UcHotel ucHotel = new UC.UcHotel();*/
            List<Address> AllAddresses = db.Addresses.ToList();
            int y = 50;
            foreach (Address h in AllAddresses)
            {
                Panel panel1;
                panel1 = new System.Windows.Forms.Panel();

                panel1.BackColor = System.Drawing.Color.White;
                panel1.Location = new System.Drawing.Point(44, 57);
                panel1.Name = "panel1";
                panel1.Size = new System.Drawing.Size(430, 59);
                panel1.TabIndex = 0;
                panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);




                this.tabPage1.Controls.Add(panel1);


                y = y + 50;
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
            Database db = new Database();
            List<Hotel> AllHotels = db.Hotels.ToList();
            foreach (Hotel h in AllHotels)
            {
                System.Windows.Forms.TableLayoutPanel tbl_Panel = new System.Windows.Forms.TableLayoutPanel();

            }



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
    }
}
