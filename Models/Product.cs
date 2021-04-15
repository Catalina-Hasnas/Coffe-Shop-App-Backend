using System;
using System.Collections.Generic;
using System.Globalization;
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

        public string Description
        {
            get
            {
                string description = "Awesome product with the name {0}, that has a price of {1}. Hurry! As of today, {2}, there are only {3} left in stock!";
                string description2 = string.Format(description, Title, PriceFormatted, CreatedAtFormatted, Amount);

                return description2;
            }
        }

        public DateTime CreatedAt { get; set; }

        public string CreatedAtFormatted
        {
            get
            {
                return CreatedAt.ToString("U", CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

    }
}
