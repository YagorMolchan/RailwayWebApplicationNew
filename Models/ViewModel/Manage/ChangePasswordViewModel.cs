using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RailwayNew1.Models.ViewModel.Manage
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Введите старое значение пароля")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Введите новое значение пароля")]
        [DataType(DataType.Password)]
        [MinLength(7, ErrorMessage = "Длина пароля должна быть не менее 7 символов!")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Подтвердите пароль")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Пароли не совпадают!")]
        public string ConfirmPassword { get; set; }
    }
}
