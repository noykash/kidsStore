using System.Collections.Generic;

namespace kidStore.Models
{
    public class Cart
    {
        //contains <productid, amount>
        public Dictionary<int, ProductInOrder> products { get; set; }

        public Cart()
        {
            products = new Dictionary<int, ProductInOrder>();
        }
    }
}
