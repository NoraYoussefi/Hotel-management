using Hotel_Project.Data;
using Hotel_Project.Properties;
using Hotel_Project.Views.UnderDashboard.add;
using Hotel_Project.Views.UnderDashboard.update;
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

            foreach( User u in allUsers)
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
            Button delete;
            Button update;

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
            delete = new System.Windows.Forms.Button();
            update = new System.Windows.Forms.Button();


                // 
                // panel3
                // 
                panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(role);
            panel3.Location = new System.Drawing.Point(7, 70 +y);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(888, 51);
            panel3.TabIndex = 5;
            panel3.SuspendLayout();
            SuspendLayout();
                // 
                // role
                // 
                role.AutoSize = true;
            role.Location = new System.Drawing.Point(670, 14);
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
            codepostal.Text = u.CodePostal.ToString();
            // 
            // country
            // 
            country.AutoSize = true;
            country.Location = new System.Drawing.Point(400, 14);
            country.Name = "country";
            country.Size = new System.Drawing.Size(72, 25);
            country.TabIndex = 32;
            country.Text = u.Country.ToString();
            // 
            // city
            // 
            city.AutoSize = true;
            city.Location = new System.Drawing.Point(498, 14);
            city.Name = "city";
            city.Size = new System.Drawing.Size(39, 25);
            city.TabIndex = 33;
            city.Text = u.City.ToString();
            // 
            // tel
            // 
            tel.AutoSize = true;
            tel.Location = new System.Drawing.Point(327, 14);
            tel.Name = "tel";
            tel.Size = new System.Drawing.Size(31, 25);
            tel.TabIndex = 31;
            tel.Text = u.Tel.ToString();
            // 
            // cin
            // 
            cin.AutoSize = true;
            cin.Location = new System.Drawing.Point(163, 14);
            cin.Name = "cin";
            cin.Size = new System.Drawing.Size(41, 25);
            cin.TabIndex = 29;
            cin.Text = u.CIN.ToString();
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new System.Drawing.Point(240, 14);
            email.Name = "email";
            email.Size = new System.Drawing.Size(54, 25);
            email.TabIndex = 30;
            email.Text = u.Email.ToString();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new System.Drawing.Point(72, 14);
            name.Name = "name";
            name.Size = new System.Drawing.Size(56, 25);
            name.TabIndex = 28;
            name.Text = u.Name.ToString();
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new System.Drawing.Point(15, 14);
            id.Name = "id";
            id.Size = new System.Drawing.Size(28, 25);
            id.TabIndex = 27;
            id.Text = u.Id.ToString();
                // 
                // update
                // 
            update.BackColor = System.Drawing.Color.White;
            update.BackgroundImage = global::Hotel_Project.Properties.Resources.editing__1_;
            update.FlatAppearance.BorderSize = 0;
            update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            update.Location = new System.Drawing.Point(770, 3);
            update.Name = u.Id.ToString();
            update.Size = new System.Drawing.Size(48, 45);
            update.TabIndex = 16;
            update.UseVisualStyleBackColor = false;
            update.Click += new System.EventHandler(this.button3_Click);
            update.Click += (s, e) => update_user(s, e);
                // 
                // delete
                // 
            delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            delete.BackColor = System.Drawing.Color.White;
            delete.BackgroundImage = global::Hotel_Project.Properties.Resources.delete;
            delete.FlatAppearance.BorderSize = 0;
            delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            delete.Location = new System.Drawing.Point(839, 3);
            delete.Name = "delete";
            delete.Size = new System.Drawing.Size(53, 46);
            delete.TabIndex = 15;
            delete.UseVisualStyleBackColor = false;
            delete.Click += new System.EventHandler(this.button4_Click);
            delete.Click += (s, e) => delete_user(s, e, u);

                /* // 
                 // update
                 // 
                 update.BackColor = System.Drawing.Color.White;
                 update.BackgroundImage = global::Hotel_Project.Properties.Resources.editing__1_;
                 update.FlatAppearance.BorderSize = 0;
                 update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                 update.Location = new System.Drawing.Point(770, 3);
                 update.Name = "update";
                 update.Size = new System.Drawing.Size(48, 45);
                 update.TabIndex = 16;
                 update.UseVisualStyleBackColor = false;
                 // 
                 // delete
                 // 
                 delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                 delete.BackColor = System.Drawing.Color.White;
                 delete.BackgroundImage = global::Hotel_Project.Properties.Resources.delete;
                 delete.FlatAppearance.BorderSize = 0;
                 delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                 delete.Location = new System.Drawing.Point(839, 3);
                 delete.Name = "delete";
                 delete.Size = new System.Drawing.Size(53, 46);
                 delete.TabIndex = 15;
                 delete.UseVisualStyleBackColor = false;
                 delete.Click += (s, e) => delete_user(s, e, u);*/

                panel3.Controls.Add( codepostal);
            panel3.Controls.Add( country);
            panel3.Controls.Add( city);
            panel3.Controls.Add( tel);
            panel3.Controls.Add( cin);
            panel3.Controls.Add( email);
            panel3.Controls.Add( name);
            panel3.Controls.Add( id);
                panel3.Controls.Add(update);
                panel3.Controls.Add(delete);
                this.Controls.Add(panel3);

                panel3.ResumeLayout(false);
                panel3.PerformLayout();
                ResumeLayout(false);

                y = y + 55;
            }
        }

        private void update_user(object s, EventArgs e)
        {

            Database db = new Database();
            Button update = (Button)s;
            int id = Int32.Parse(update.Name.ToString());
            User user = db.Users.Where(u => u.Id == id).First();

            updateUser updateUser = new updateUser(user);
            updateUser.Show();
        }

        private void delete_user(object s, EventArgs e, User u)
        {
            
            Database db = new Database();
            User user = new User() { Id = u.Id };
            db.Users.Attach(user);
            db.Users.Remove(user);
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*updateUser updateUser = new updateUser(user);
            updateUser.Show();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void cin_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void tel_Click(object sender, EventArgs e)
        {

        }

        private void country_Click(object sender, EventArgs e)
        {

        }

        private void city_Click(object sender, EventArgs e)
        {

        }

        private void codepostal_Click(object sender, EventArgs e)
        {

        }

        private void role_Click(object sender, EventArgs e)
        {

        }
    }
}
