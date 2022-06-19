﻿using Hotel_Project.Data;
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
    public partial class Categories : Form
    {
        private Hotel h;

        public Categories()
        {
            InitializeComponent();
        }

        public Categories(Hotel h)
        {
            InitializeComponent();
            this.h = h;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Categories_Load(object sender, EventArgs e)
        {
            

             Database db = new Database();
             List<Category> AllCategories = db.Categories.ToList();
           
             this.panel1.Size = new System.Drawing.Size(900 + (AllCategories.Count - 3) * 240, 686);


            int x = 0;
            for (int i = 0; i < AllCategories.Count; i++)
            {
                Category c = AllCategories[i];


                Panel panel5;
                Button button1;
                Label label2;
                Label label3;
                PictureBox pictureBox2;

                pictureBox2 = new System.Windows.Forms.PictureBox();
                panel5 = new System.Windows.Forms.Panel();
               
                button1 = new System.Windows.Forms.Button();
                label2 = new System.Windows.Forms.Label();
                label3 = new System.Windows.Forms.Label();
                Label label4 = new System.Windows.Forms.Label(); ;

                panel1.SuspendLayout();
                panel5.SuspendLayout();

                this.SuspendLayout();
                this.SuspendLayout();


                // 
                // pictureBox2
                // 
                pictureBox2.Image = global::Hotel_Project.Properties.Resources.hotel1;
                pictureBox2.Location = new System.Drawing.Point(0, 0);
                pictureBox2.Name = "pictureBox2";
                pictureBox2.Size = new System.Drawing.Size(224, 169);
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox2.TabIndex = 3;
                pictureBox2.TabStop = false;
               
                

                // 
                // panel5
                // 
                panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                panel5.Location = new System.Drawing.Point(60 + x, 161);
                panel5.Name = "panel5";
                panel5.Size = new System.Drawing.Size(224, 337);
                panel5.TabIndex = 2;
                panel5.SendToBack();
                // 
                // label2
                // 
                label2.AutoSize = true;
                label2.Location = new System.Drawing.Point(41, 200);
                label2.Name = "label2";
                label2.Size = new System.Drawing.Size(141, 25);
                label2.TabIndex = 3;
                label2.Text = c.CategoryPrice.ToString() + "euro";
                // 
                // label3
                // 
                label3.Location = new System.Drawing.Point(41, 230);
                label3.Name = "label3";
                label3.Size = new System.Drawing.Size(242, 74);
                label3.TabIndex = 3;
                label3.Text = c.Description.ToString();
                // 
                // label4
                // 
                label4.AutoSize = true;
                label4.Location = new System.Drawing.Point(148, 112);
                label4.Name = "label2";
                
                label4.TabIndex = 3;
                label4.AutoSize = true;
                label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
                label4.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                
                label4.Size = new System.Drawing.Size(700, 33);
                label4.Text ="welcome to"+ h.Name.ToString() +" hotel, we are rated " +h.CassementId.ToString() +"stars and we exist in "+ h.Address.City.ToString();
                // 
                // button1
                // 
                button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
                button1.FlatAppearance.BorderSize = 0;
                button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                button1.Location = new System.Drawing.Point(60, 284);
                button1.Name = "button1";
                button1.Size = new System.Drawing.Size(112, 34);
                button1.TabIndex = 2;
                button1.Text = "Choose";
                button1.UseVisualStyleBackColor = false;
                button1.Click += (s, e) => chooseCategory(s, e, h, c);
               

                panel5.Controls.Add(pictureBox2);
                panel5.Controls.Add(button1);
                panel5.Controls.Add(label2);
                panel5.Controls.Add(label3);
                panel1.Controls.Add(panel5);
                panel1.Controls.Add(label4);


                x = x + 240;
                panel5.ResumeLayout(false);
                panel5.PerformLayout();

            }
        }

        private void chooseCategory(object s, EventArgs e, Hotel h, Category c)
        {
            Rooms rooms = new Rooms( h,  c);
            rooms.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
