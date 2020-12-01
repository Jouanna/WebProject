using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebProject2020.Data.Enumerations;
using WebProject2020.Data.Models;

namespace WebProject2020.Models
{
    public class Details
    {
        public Details()
        {
            this.VehiclesDetails = new HashSet<VehicleDetails>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [Range(1950, 2020)]
        public int Year { get; set; }

        [Required]
        public FuelType Fuel { get; set; }

        [Required]
        [Range(60, 500)]
        public int HorsePower { get; set; }
        public string Color { get; set; }

        [Required]
        public decimal Price { get; set; }

        public ICollection<VehicleDetails> VehiclesDetails { get; set; }

    }
}
