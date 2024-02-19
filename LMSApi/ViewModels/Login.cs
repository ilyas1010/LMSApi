using System.ComponentModel.DataAnnotations;
namespace LMSApi.ViewModels;

    public class Login
    {
        [Required(ErrorMessage ="User Name Required")]
       
        public string UserId { get; set; }

        [Required(ErrorMessage ="Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

