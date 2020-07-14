using StoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplication.WebApp.ViewModels
{
    public class OrderViewModel
    {
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderPlaced { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        [Display(Name = "Order Total")]
        public decimal OrderTotal { get; set; }

    }
}
