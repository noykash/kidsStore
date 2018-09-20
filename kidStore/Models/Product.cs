using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace kidStore.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int productId { get; set; }

        [DisplayName("Category")]
        public int categoryId { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(160)]
        public string name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 1000000.00, ErrorMessage = "Price must be between 0.01 and 1000000.00")]
        public decimal price { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(0.00, 1000000, ErrorMessage = "Quantity must be between 0 and 1000000 and a whole number")]
        public int quantity { get; set; }

        [DisplayName("Product image URL")]
        public string imageUrl { get; set; }

        //TODO:there is no reference/shoud find the reference
        //public HttpPostedFileBase mageFile { get; set; }
        [NotMapped]
        public string imageFile { get; set; }

        public Age age { get; set; }

        public virtual Category category { get; set; }
    }
}
