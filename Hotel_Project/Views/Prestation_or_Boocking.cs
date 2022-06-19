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
    public partial class Prestation_or_Boocking : Form
    {
        public Prestation_or_Boocking()
        {
            InitializeComponent();
        }

        private void borderRaduis1_Click(object sender, EventArgs e)
        {
            Hotels hotels = new Hotels();
            hotels.Show();
            this.Close();
        }

        private void borderRaduis2_Click(object sender, EventArgs e)
        {
            PrestationView prestation = new PrestationView();
            prestation.Show();
            this.Close();
        }

        private void borderRaduis3_Click(object sender, EventArgs e)
        {
            FactureView factureView = new FactureView();
            factureView.Show();
            this.Close();
        }

        private void borderRaduis4_Click(object sender, EventArgs e)
        {

            dashboard a = new dashboard();
            a.Show();
        }

        private void borderRaduis5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
