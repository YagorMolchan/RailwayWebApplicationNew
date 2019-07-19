using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RailwayNew1.Models.ViewModel.Manage
{
    public class EditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите фамилию!")]
        public string Surename { get; set; }

        [Required(ErrorMessage = "Введите имя!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите электронный адрес!")]
        [EmailAddress(ErrorMessage = "Неверный формат ввода!")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(\s*)?(\+)?([- _():=+]?\d[- _():=+]?){10,14}(\s*)?", ErrorMessage = "Введите номер телефона в международном формате")]
        public string Phone { get; set; }
    }
}
