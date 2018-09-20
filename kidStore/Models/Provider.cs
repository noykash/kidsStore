using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace kidStore.Models
{
    public class Provider
    {
        [ScaffoldColumn(false)]
        public int id { get; set; }
        public int categoryId { get; set; }

        [Required(ErrorMessage = "Provider name is required")]
        [StringLength(160)]
        public string name { get; set; }

        [Required(ErrorMessage = "The category of the provider is required")]
        [DisplayName("Category")]
        public virtual Category category { get; set; }

        [Required(ErrorMessage = "The provider's address is required")]
        public string address { get; set; }
    }
}
