using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Project.Data
{
    public class Client
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string CIN { get; set; }
        public string Email { get; set; }
        public int Tel { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string CodePostal { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
       

        public ICollection<Reservation> Reservations { get; set; }
    }
}
