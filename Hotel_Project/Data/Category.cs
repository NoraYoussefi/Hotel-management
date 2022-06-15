using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Project.Data
{
    internal class Category
    {   
        public int Id { get; set; }
        public int CategoryPrice { get; set; }
        public string Description { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
