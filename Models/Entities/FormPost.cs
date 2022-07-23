using System;
using System.ComponentModel.DataAnnotations;

namespace TestTask.Models.Entities
{
    public class FormPost
    {
        public FormPost()
        {
            OrderDate = DateTime.UtcNow;
        }

        [Required]
        [Display(Name = "Номер заказа")]
        public int Id { get; set; }

        [Display(Name = "Город отправителя")]
        public string SenderCity { get; set; }

        [Display(Name = "Адрес отправителя")]
        public string AddressSender { get; set; }

        [Display(Name = "Город получателя")]
        public string ResipientCity { get; set; }

        [Display(Name = "Адрес получателя")]
        public string AddressResipient { get; set; }

        [Display(Name = "Вес груза(кг)")]
        public double CargoWeight { get; set; }

        [Display(Name = "Дата забора груза")]
        public DateTime DateReceipt { get; set; }

        [Display(Name = "Дата формирования заказа")]
        public DateTime OrderDate { get; set; }
    }
}
