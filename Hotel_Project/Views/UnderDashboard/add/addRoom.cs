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
    public partial class addRoom : Form
    {
        public addRoom()
        {
            InitializeComponent();
        }

        private void borderRaduis1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            Room room = new Room();
         /*   room.Id = db.Rooms.Max(x => x.Id) + 1;*/
            room.price = Int32.Parse(placeHolderTextBox3.Text);
            room.Num = placeHolderTextBox6.Text;
            room.IsReserved = Boolean.Parse(placeHolderTextBox4.Text);
            room.RoomTel = Int32.Parse(placeHolderTextBox2.Text);
            room.HotelId = Int32.Parse(placeHolderTextBox5.Text);
            room.CategoryId = Int32.Parse(placeHolderTextBox7.Text);

            db.Rooms.Add(room);
            db.SaveChanges();
            this.Close();
        }

        private void addRoom_Load(object sender, EventArgs e)
        {
             
        }

        private void placeHolderTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
