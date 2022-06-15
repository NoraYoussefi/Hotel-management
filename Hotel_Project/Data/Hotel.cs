using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Project.Data
{
    internal class Hotel
    {
        
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Image { get; set; }
        public int NumTel { get; set; }


        public int CassementId { get; set; }
        public int AddressId { get; set; }
        public Classement Cassement { get; set; }
        public Address Address { get; set; }
        public ICollection<Room> Room { get; set; }



    }
}
