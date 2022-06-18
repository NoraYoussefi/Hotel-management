using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Project.Data
{
    public class Classement
    {
       
        public int Id { get; set; }
        public int Rate { get; set; }
        public int coef { get; set; }
        public ICollection<Hotel> hotels { get; set; }
    }
}
