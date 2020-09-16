using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.DTO
{
    public class ProductDTO
    {

        //1.    Product Name
        //2.	Rating
        //3.	Price
        //4.	Users
        //5.	Type
        //6.	Description

        public string ProductName { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public int Users { get; set; }
        public string Description { get; set; }
    }
}
