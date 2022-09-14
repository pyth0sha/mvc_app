﻿using System.ComponentModel.DataAnnotations;

namespace mvc_app.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не указан номер")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
