using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Project.Data
{
    internal class Prestation
    {
        
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public float price { get; set; }


        public ICollection<Reservation> Reservations { get; set; }
    }
}
