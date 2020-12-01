using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject2020.Data.Models
{
    public class Deals
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }
        public int SellerId { get; set; }
        public int VehicleId { get; set; }

    }
}
