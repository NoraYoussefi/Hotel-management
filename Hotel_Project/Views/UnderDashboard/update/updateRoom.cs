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
    public partial class updateRoom : Form
    {
        Database db = new Database();
        public Room room;
        public int id;

        public updateRoom(Room room)
        {
            InitializeComponent();
            this.room = room;
        }

        private void borderRaduis1_Click(object sender, EventArgs e)
        {
            room.price = Int32.Parse(placeHolderTextBox2.Text);
            room.IsReserved = Boolean.Parse(placeHolderTextBox3.Text);
            room.RoomTel = Int32.Parse(placeHolderTextBox1.Text);
            room.HotelId = Int32.Parse(placeHolderTextBox4.Text);
            room.Num = placeHolderTextBox5.Text;
            room.CategoryId = Int32.Parse(textBox1.Text);

            db.Rooms.Attach(room);
            db.Entry(room).State = EntityState.Modified;
            db.SaveChanges();
            this.Close();
        }

        private void updateRoom_Load(object sender, EventArgs e)
        {
            placeHolderTextBox1.Text = room.RoomTel.ToString();
            placeHolderTextBox2.Text = room.price.ToString();
            placeHolderTextBox3.Text = room.IsReserved.ToString();
            placeHolderTextBox4.Text = room.HotelId.ToString();
            placeHolderTextBox5.Text = room.Num.ToString();
            textBox1.Text = room.CategoryId.ToString();
        }
    }
}
