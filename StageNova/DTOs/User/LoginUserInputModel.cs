using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static StageNova.Common.Constants.ValidationConstants.UserConstants;
using static StageNova.Common.Messages.ErrorMessages.UserMessages;

namespace StageNova.DTOs.User
{
    public class LoginUserInputModel
    {
        [Required(ErrorMessage = UsernameIsRequired)]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = PasswordIsRequired)]
        [MinLength(PasswordMinLength)]
        [MaxLength(PasswordMaxLength)]
        public string Password { get; set; } = null!;
    }
}
