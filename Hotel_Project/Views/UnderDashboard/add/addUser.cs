using Hotel_Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Project.Views.UnderDashboard.add
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void placeHolderTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEmployee_Load(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void borderRaduis1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            User user  = new User();
            user.Name = placeHolderTextBox1.Text;
            user.CIN = placeHolderTextBox2.Text;
            user.Email = placeHolderTextBox3.Text;
            user.Tel = Int32.Parse(placeHolderTextBox4.Text);
            user.Country = placeHolderTextBox5.Text;
            user.City=placeHolderTextBox6.Text;
            user.CodePostal = placeHolderTextBox7.Text;
            user.Address = placeHolderTextBox8.Text;
            user.Password= placeHolderTextBox9.Text;
            user.Role = (Role)Int32.Parse(placeHolderTextBox10.Text);
            

            db.Users.Add(user);
            db.SaveChanges();
            this.Close();
        }
    }
}
