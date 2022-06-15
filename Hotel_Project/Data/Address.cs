using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Project.Data
{
    internal class Address
    {   
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CodePostal { get; set; }
        public string Detail { get; set; }    
        public Hotel Hotel { get; set; }

    }
}
