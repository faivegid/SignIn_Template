using System.ComponentModel.DataAnnotations;

namespace SiginIn_Template.Data.Models.DtoModels
{
    public class ResetPasswordModel
    {
        [Required]
        public string NewPassword { get; set; }

        [Required]
        [Compare("NewPassword", ErrorMessage ="Password must match")]
        public string ConfirmPAssword { get; set; }

    }
}
