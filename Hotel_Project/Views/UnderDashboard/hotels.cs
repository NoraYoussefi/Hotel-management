﻿using Hotel_Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Project.Views.UnderDashboard
{
    public partial class hotels : Form
    {
        public hotels()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hotels_Load(object sender, EventArgs e)
        {
            Database db = new Database();

            List<Hotel> AllHotels = db.Hotels.ToList();
            int y = 54;
            foreach (Hotel h in AllHotels)
            {
                Panel panel1;
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
                Id_hotel.Location = new System.Drawing.Point(9, 9);
                Id_hotel.Name = "Id_hotel";
                Id_hotel.Size = new System.Drawing.Size(28, 25);
                Id_hotel.TabIndex = 10;
                Id_hotel.Text = h.Id.ToString();
                Id_hotel.BringToFront();

                //hotel_title
                Label hotel_title;
                hotel_title = new System.Windows.Forms.Label();

                hotel_title.AutoSize = true;
                hotel_title.Location = new System.Drawing.Point(102, 12);
                hotel_title.Name = "hotel_title";
                hotel_title.Size = new System.Drawing.Size(41, 25);
                hotel_title.TabIndex = 11;
                hotel_title.Text = h.Name;


                panel1.Controls.Add(hotel_title);
                panel1.Controls.Add(Id_hotel);
                this.Controls.Add(panel1);

                y = y + 54;

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

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}