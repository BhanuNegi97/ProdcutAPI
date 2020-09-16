using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Model
{
    public class ServiceResponse<T> 
    {
        public T  data { get; set; }
      
        public bool success { get; set; }
        public string message { get; set; }
    }
}
