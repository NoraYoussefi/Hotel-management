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
    public partial class PrestationView : Form
    {
        public PrestationView()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Prestation_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            // Set the location of the ComboBox 

            // Set the size of the ComboBox

            // Add items in the ComboBox
            comboBox1.Items.Add("food");
            comboBox1.Items.Add("car");
            comboBox1.Items.Add("spa");
            comboBox1.Items.Add("clothes Cleaning");


          
        }

        private void borderRaduis1_Click(object sender, EventArgs e)
        {

            Database db = new Database();
            Prestation prestation = new Prestation();

            prestation.Name = placeHolderTextBox1.Text;
            prestation.price = float.Parse(placeHolderTextBox2.Text);
            prestation.Date = dateTimePicker1.Value;
            prestation.Category = comboBox1.Text;


            MessageBox.Show("done");
            db.Prestations.Add(prestation);
            db.SaveChanges();
            this.Close();


        }
    }
}
