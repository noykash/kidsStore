using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kidStore.Models
{
    public class ProductInOrder
    {
        public Product product { get; set; }

        public int amount { get; set; }
    }
}
