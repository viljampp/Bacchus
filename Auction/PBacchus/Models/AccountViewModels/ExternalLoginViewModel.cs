using System.ComponentModel.DataAnnotations;

namespace Bacchus.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
