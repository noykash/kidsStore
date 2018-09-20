using System.ComponentModel.DataAnnotations;

namespace kidStore.Models
{
    public class User
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        public string password { get; set; }
        public bool isManager { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        [Display(Name = "User name")]
        public string userName { get; set; }

        public string address { get; set; }

    }
}
