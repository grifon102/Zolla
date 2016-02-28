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
        New,
        Processed,
        Ready,
        Cancelled
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
