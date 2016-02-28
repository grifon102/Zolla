using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zolla.Data.Entities
{
    public enum Status
    {
        [Display(Name = "Новый")]
        New = 1,
        [Display(Name = "Обработанно")]
        Processed = 2,
        [Display(Name = "Готов")]
        Ready = 3,
        [Display(Name = "Отменен")]
        Cancelled = 4
    }

    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Статус заказа")]
        public Status? Status { get; set; }
        public int? ClientId { get; set; }
        public Client Client { get; set; }
    }
}
