using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Project.Data
{
    public class Room
    {
        [Key]
        public int Id{ get; set; }
        public string Num { get; set; }
        public int RoomTel { get; set; }
        public float price { get; set; }
        public Boolean IsReserved { get; set; }


        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
       
        public ICollection<Reservation> Reservations { get; set; }
    }
}
