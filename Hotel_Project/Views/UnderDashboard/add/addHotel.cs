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
    public partial class addHotel : Form
    {
        public addHotel()
        {
            InitializeComponent();
        }

        private void borderRaduis1_Click(object sender, EventArgs e)
        {

            Database db = new Database();
            Hotel hotel = new Hotel();
            hotel.Id = db.Hotels.Max(x => x.Id) + 1;
            hotel.Name = placeHolderTextBox1.Text;
            hotel.AddressId = Int32.Parse(placeHolderTextBox4.Text);
            hotel.CassementId = Int32.Parse(placeHolderTextBox3.Text);
            hotel.NumTel = Int32.Parse(placeHolderTextBox2.Text);
            hotel.Image = placeHolderTextBox5.Text;

            db.Hotels.Add(hotel);
            db.SaveChanges();
            this.Close();

        }

        private void addHotel_Load(object sender, EventArgs e)
        {

        }
    }
}
