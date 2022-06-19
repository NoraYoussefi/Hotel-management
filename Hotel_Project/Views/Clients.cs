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

namespace Hotel_Project.Views
{
    public partial class Clients : Form
    {
        private Hotel h;
        private Category c;
        private Room r;

        public Clients()
        {
            InitializeComponent();
        }

        public Clients(Hotel h, Category c, Room r)
        {
            InitializeComponent();

            this.h = h;
            this.c = c;
            this.r = r;
        }

        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private void borderRaduis1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            Client client = new Client();
            client.Name = placeHolderTextBox1.Text;
            client.CIN = placeHolderTextBox2.Text;
            client.Email = placeHolderTextBox3.Text;
            client.Tel = Int32.Parse(placeHolderTextBox4.Text);
            client.Country = placeHolderTextBox5.Text;
            client.City = placeHolderTextBox6.Text;
            client.CodePostal = placeHolderTextBox7.Text;
            client.Address = placeHolderTextBox8.Text;
            client.Password = placeHolderTextBox9.Text;


            db.Clients.Add(client);
            db.SaveChanges();

            ReservationView facture = new ReservationView(h,c,r,client);
            facture.Show();

            this.Close();
        }
    }
}
