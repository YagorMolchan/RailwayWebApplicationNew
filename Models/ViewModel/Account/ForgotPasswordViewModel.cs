using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RailwayNew1.Models.ViewModel.Account
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Введите электронный адрес!")]
        [EmailAddress(ErrorMessage = "Неверный формат ввода!")]
        public string Email { get; set; }
    }
}
