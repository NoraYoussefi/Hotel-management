using Hotel_Project.Data;
using Hotel_Project.Views;
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
    public partial class ReservationView : Form
    {
        private Hotel h;
        private Category c;
        private Room r;
        private Client client;

        public ReservationView()
        {
            InitializeComponent();
        }

        public ReservationView(Hotel h, Category c, Room r, Client client)
        {
            InitializeComponent();
            this.h = h;
            this.c = c;
            this.r = r;
            this.client = client;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void borderRaduis1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            Reservation reservation = new Reservation();

            reservation.Name = placeHolderTextBox3.Text;
            reservation.arrhes= float.Parse(placeHolderTextBox10.Text);
            reservation.datePayeArrhes = dateTimePicker3.Value;
            reservation.startDate = dateTimePicker1.Value;
            reservation.endDate = dateTimePicker2.Value;

            reservation.UserId = 3;
            reservation.ClientId = client.Id;
            reservation.RoomId = r.Id;
            reservation.price =( r.price ) * (reservation.endDate.Date - reservation.startDate.Date).Days - reservation.arrhes;
            MessageBox.Show(reservation.price.ToString());
            db.Reservations.Add(reservation);
            db.SaveChanges();

            FactureView factureView = new FactureView(h,c,r,client, reservation);
            /*factureView.Show();*/
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void borderRaduis2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
