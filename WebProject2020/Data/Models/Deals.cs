using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject2020.Data.Models
{
    public class Deals
    {
        public int Id { get; set; }

        [ForeignKey("BuyerInfo")]
        public int BuyerId { get; set; }
        public BuyerInfo BuyerInfo { get; set; }

        [ForeignKey("SellerInfo")]
        public int SellerId { get; set; }
        public SellerInfo SellerInfo { get; set; }

        [ForeignKey("VehicleDetails")]
        public int VehicleId { get; set; }
        public VehicleDetails VehicleDetails { get; set; }

        public DateTime Date { get; set; }

    }
}
