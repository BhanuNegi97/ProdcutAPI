using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Model
{
    public class Product
    {
        public int productId { get; set; }
        public string name { get; set; }
        public string imagee { get; set; }
        public string type { get; set; }
        public double price { get; set; }
        public double rating { get; set; }
        public int users { get; set; }
        public DateTime last_update { get; set; }
        public string description { get; set; }
        public string url { get; set; }

    }
}
