using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Domain.Models
{
    public class Inventory
    {
   
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public Store Location { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
