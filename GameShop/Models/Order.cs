using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введите имя: ")]
        [StringLength(25)]
        [Required(ErrorMessage = "Вы не заполнили поле!")]
        public string name { get; set; }
        [Display(Name = "Введите фамилию: ")]
        [StringLength(25)]
        [Required(ErrorMessage = "Вы не заполнили поле!")]
        public string surname { get; set; }
        [Display(Name = "Введите адрес: ")]
        [StringLength(25)]
        [Required(ErrorMessage = "Вы не заполнили поле!")]
        public string adress { get; set; }
        [Display(Name = "Введите номер телефона: ")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(13)]
        [Required(ErrorMessage = "Вы не заполнили поле или заполнили его неверно!")]
        public string phone { get; set; }
        [Display(Name = "Введите email: ")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Вы не заполнили поле или заполнили его неверно!")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
