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
    public partial class updateHotel : Form
    {
        public Hotel hotel;
        public int id;


        /*public updateHotel()
        {
            InitializeComponent();
        }*/


        public updateHotel(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void placeHolderTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateHotel_Load(object sender, EventArgs e)
        {
            placeHolderTextBox1.Text = hotel.Name;
            placeHolderTextBox2.Text = hotel.NumTel.ToString();
            placeHolderTextBox3.Text = hotel.CassementId.ToString();
            placeHolderTextBox4.Text = hotel.AddressId.ToString();
            placeHolderTextBox5.Text = hotel.Image.ToString();

          
        }

        private void borderRaduis1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
           /* Hotel hotel = new Hotel();*/

            hotel.Name = placeHolderTextBox1.Text;
            hotel.NumTel = Int32.Parse(placeHolderTextBox2.Text.ToString());
            hotel.CassementId = Int32.Parse(placeHolderTextBox3.Text.ToString());
            hotel.AddressId = Int32.Parse(placeHolderTextBox4.Text.ToString());
            hotel.Image = placeHolderTextBox5.Text.ToString();
            db.Hotels.Attach(hotel);
            db.Entry(hotel).State = EntityState.Modified;
            db.SaveChanges();
            this.Close();

        }

        private void placeHolderTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
