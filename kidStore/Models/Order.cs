using System.Collections.Generic;

namespace kidStore.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public int userId { get; set; }
        public string address { get; set; }
        public decimal total { get; set; }
        public System.DateTime orderDate { get; set; }
        public List<ProductOrder> productsInOrder { get; set; }
    }
}
