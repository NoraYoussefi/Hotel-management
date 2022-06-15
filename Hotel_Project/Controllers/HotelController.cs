using Hotel_Project.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Project.Controllers
{
    internal class HotelController : Address
    {
        public Address getAddress(int Id)
        {

            var context = new Database();
            Address address = (Address)context.Addresses.Where(Address => Address.Id == Id).FirstOrDefault();
            return address;
        }

       // public List<Address> GetAddresses()
       // {

            //  var context = new DbContext();
            //   List Address addresses = context.Address.ToList(); 
            //   return addresses;

            //Database db = new Database();
            // List<Address> Addresses = db.Addresses.Include("Addresses").ToList();
            // return addresses;
           // return 0;
       // }

    }
}
