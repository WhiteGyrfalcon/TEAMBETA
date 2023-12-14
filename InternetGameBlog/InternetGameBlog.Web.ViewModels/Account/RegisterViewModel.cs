using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InternetGameBlog.Common.EntityValidationConstants.User;


namespace InternetGameBlog.Web.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(FirstNameMinLength, MinimumLength = FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(FirstNameMinLength, MinimumLength = FirstNameMinLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(EmailMaxLength, MinimumLength = EmailMinLength)]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength)]

        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength)]
        public string PasswordRepeat { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        public IFormFile? ProfilePicture { get; set; }

    }
}
