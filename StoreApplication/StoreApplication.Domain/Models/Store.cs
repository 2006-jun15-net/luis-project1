using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Domain.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }

        public ICollection<Inventory> Inventory { get; set; }

    }
}
