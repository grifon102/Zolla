using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zolla.Data.Entities
{
    public class Client
    {
        public int Id { get; set; }
        [Display(Name = "Название клиента")]
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm:ss}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Дата добавления")]
        public DateTime DateAdd { get; set; }
        
        public virtual IList<Order> Orders { get; set; }
    }
}
