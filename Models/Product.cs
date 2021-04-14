using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amdaris_Backend.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string PriceFormatted { get; set; }
        public string Title { get; set; }

    }
}
