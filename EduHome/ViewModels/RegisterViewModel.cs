using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class RegisterViewModel
    {
        [Required, StringLength(maximumLength: 100)]
        public string FullName { get; set; }
        [Required, StringLength(maximumLength: 20)]
        public string UserName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password), ErrorMessage = "Confirm Password and Password do not match.")]
        public string ConfirmPassword { get; set; }


    }
}
