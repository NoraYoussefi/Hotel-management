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

namespace Hotel_Project.Views.UnderDashboard.update
{
    public partial class updateUser : Form
       
    {
        public User user;
        public int id;
        public updateUser(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void borderRaduis1_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            user.Name = textBox1.Text;
            user.CIN = textBox2.Text;
            user.Email = textBox3.Text;
            user.Tel = Int32.Parse(textBox4.Text);
            user.Country = textBox5.Text;
            user.City = textBox6.Text;
            user.CodePostal = textBox7.Text;
            user.Address = textBox8.Text;
            user.Password = textBox9.Text;
            user.Role = (Role)Int32.Parse(textBox10.Text.ToString());

            db.Users.Attach(user);
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            this.Close();
        }

        private void placeHolderTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateUser_Load(object sender, EventArgs e)
        {
            textBox1.Text = user.Name;
            textBox2.Text = user.CIN.ToString();
            textBox3.Text = user.Email;
            textBox4.Text = user.Tel.ToString();
            textBox5.Text = user.Country;
            textBox6.Text = user.City;
            textBox7.Text = user.CodePostal;
            textBox8.Text = user.Address;
            textBox9.Text = user.Password;
            textBox10.Text = user.Role.ToString();

        }

        private void placeHolderTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
