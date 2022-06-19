using Hotel_Project.Data;
using System.Drawing.Printing;

namespace Hotel_Project.Views
{
    public partial class FactureView : Form
    {
        private Hotel h;
        private Category c;
        private Room r;
        private Client client;
        private Reservation reservation;

        public FactureView()
        {
            InitializeComponent();
        }

        public FactureView(Hotel h, Category c, Room r, Client client, Reservation reservation)
        {
            this.h = h;
            this.c = c;
            this.r = r;
            this.client = client;
            this.reservation = reservation;
        }

        private void FactureView_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void borderRaduis1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            PrestationReservation facture = new PrestationReservation();

            facture.DateFacture = dateTimePicker1.Value;
            facture.Id =    Int32.Parse(textBox1.Text.ToString());
            /*            facture.Total = Int32.Parse(totalPrice.Text.ToString());
            */
            facture.Total = 1500;


           id.Text = textBox1.Text;
            name.Text = textBox2.Text;
            hotelName.Text= textBox3.Text;
            totalPrice.Text = 1500 + "DH";



            date.Text=dateTimePicker1.Value.ToString();

            /*  date.Text = facture.DateFacture.ToString();
              totalPrice.Text = facture.Total.ToString();*/
          /*  db.PrestationReservations.Add(facture);
            db.SaveChanges();
*/


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void borderRaduis2_Click(object sender, EventArgs e)
        {
            id.Text = "";
            name.Text = "";
            hotelName.Text = "";
            totalPrice.Text = "";
            date.Text = "";

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void borderRaduis3_Click(object sender, EventArgs e)
        {/*
            PrintPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
          */
            this.Close();

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(panel2.Text, new Font("Microsoft JhengHei", 12, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }
    }
}
