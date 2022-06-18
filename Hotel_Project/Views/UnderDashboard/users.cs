using Hotel_Project.Data;
using Hotel_Project.Views.UnderDashboard.add;
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

namespace Hotel_Project.Views.UnderDashboard
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void add_room_Click(object sender, EventArgs e)
        {
           
            addUser addUser= new addUser();
            addUser.Show();
        }

        private void users_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            List<User> allUsers = db.Users.ToList();
        

            int y = 55;

            foreach( User u in db.Users )
            {

            Panel panel3;
            Label role;
            Label codepostal;
            Label country;
            Label city;
            Label tel;
            Label cin;
            Label email;
            Label name;
            Label id;

            panel3 = new System.Windows.Forms.Panel();
            role = new System.Windows.Forms.Label();
            codepostal = new System.Windows.Forms.Label();
            country = new System.Windows.Forms.Label();
            city = new System.Windows.Forms.Label();
            tel = new System.Windows.Forms.Label();
            cin = new System.Windows.Forms.Label();
            email = new System.Windows.Forms.Label();
            name = new System.Windows.Forms.Label();
            id = new System.Windows.Forms.Label();



            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(role);
            panel3.Controls.Add(this.codepostal);
            panel3.Controls.Add(this.country);
            panel3.Controls.Add(this.city);
            panel3.Controls.Add(this.tel);
            panel3.Controls.Add(this.cin);
            panel3.Controls.Add(this.email);
            panel3.Controls.Add(this.name);
            panel3.Controls.Add(this.id);
            panel3.Controls.Add(this.button3);
            panel3.Controls.Add(this.button4);
            panel3.Location = new System.Drawing.Point(7, 127 +y);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(888, 51);
            panel3.TabIndex = 5;
            // 
            // role
            // 
            role.AutoSize = true;
            role.Location = new System.Drawing.Point(686, 14);
            role.Name = "role";
            role.Size = new System.Drawing.Size(46, 25);
            role.TabIndex = 35;
            role.Text =u.Role.ToString();
            // 
            // codepostal
            // 
            codepostal.AutoSize = true;
            codepostal.Location = new System.Drawing.Point(562, 14);
            codepostal.Name = "codepostal";
            codepostal.Size = new System.Drawing.Size(103, 25);
            codepostal.TabIndex = 34;
            codepostal.Text = "Postal code";
            // 
            // country
            // 
            country.AutoSize = true;
            country.Location = new System.Drawing.Point(400, 14);
            country.Name = "country";
            country.Size = new System.Drawing.Size(72, 25);
            country.TabIndex = 32;
            country.Text = "country";
            // 
            // city
            // 
            city.AutoSize = true;
            city.Location = new System.Drawing.Point(498, 14);
            city.Name = "city";
            city.Size = new System.Drawing.Size(39, 25);
            city.TabIndex = 33;
            city.Text = "city";
            // 
            // tel
            // 
            tel.AutoSize = true;
            tel.Location = new System.Drawing.Point(327, 14);
            tel.Name = "tel";
            tel.Size = new System.Drawing.Size(31, 25);
            tel.TabIndex = 31;
            tel.Text = "tel";
            // 
            // cin
            // 
            cin.AutoSize = true;
            cin.Location = new System.Drawing.Point(163, 14);
            cin.Name = "cin";
            cin.Size = new System.Drawing.Size(41, 25);
            cin.TabIndex = 29;
            cin.Text = "CIN";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new System.Drawing.Point(240, 14);
            email.Name = "email";
            email.Size = new System.Drawing.Size(54, 25);
            email.TabIndex = 30;
            email.Text = "email";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new System.Drawing.Point(72, 14);
            name.Name = "name";
            name.Size = new System.Drawing.Size(56, 25);
            name.TabIndex = 28;
            name.Text = "name";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new System.Drawing.Point(15, 14);
            id.Name = "id";
            id.Size = new System.Drawing.Size(28, 25);
            id.TabIndex = 27;
            id.Text = "Id";



                y= y + 55;
            }
        }
    }
}
