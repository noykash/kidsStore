using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace kidStore.Models
{
    public class Category
    {
        public int categoryId { get; set; }

        [DisplayName("Category Name")]
        public string name { get; set; }

        public string imageUrl { get; set; }

        public string description { get; set; }

        public virtual List<Product> products { get; set; }
    }
}
