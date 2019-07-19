using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RailwayNew1.Models.ViewModel.Account
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Введите пароль!")]
        [DataType(DataType.Password)]
        [MinLength(7, ErrorMessage = "Длина пароля должна быть не менее 7 символов!")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают!")]
        public string ConfirmPassword { get; set; }
    }
}
