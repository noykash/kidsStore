using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kidStore.Models
{
    public class ProductOrder
    {
        public int productOrderId { get; set; }

        public int amount { get; set; }

        public int productId { get; set; }

        public virtual Product product { get; set; }
    }
}
