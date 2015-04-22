using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BSUIR.Chepurok.EducationEpam.UI.Models
{
  public class RegisterViewModel
  {
    [HiddenInput(DisplayValue = false)]
    [ScaffoldColumn(false)]
    public int Id { get; set; }

    [Required(ErrorMessage = "*")]
    [Display(Name = "Введите имя пользователя")]
    [MinLength(2, ErrorMessage = "Минимум 2 символа")]
    public string Firstname { get; set; }

    [Required(ErrorMessage = "*")]
    [Display(Name = "Введите фамилию пользователя")]
    [MinLength(2, ErrorMessage = "Минимум 2 символа")]
    public string Surname { get; set; }

    [Display(Name = "Введите email")]
    [Required(ErrorMessage = "*")]
    [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "*")]
    [StringLength(100, ErrorMessage = "Пароль должен содержать по крайней мере {2} символов.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Введите пароль")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Подтвердите пароль")]
    [DataType(DataType.Password)]
    [Display(Name = "Подтвердите пароль")]
    [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Пароли должны совпадать.")]
    public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "*")]
    [MinLength(2, ErrorMessage = "Минимум 2 символа")]
    [Display(Name = "Введите должность пользователя")]
    public string Post { get; set; }

    public string Image { get; set; }
  }
}