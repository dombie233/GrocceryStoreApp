using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocceryStoreApp.ConsoleApp
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        
        public string Manufacturer { get; set; }
        public DateTime expirationDate { get; set; }
        public string Category { get; set; }

    }
}
