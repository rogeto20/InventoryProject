using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProject.Abstractions.Models
{
    public class ProductDomainModel
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int QuantityInStock { get; set; }
        public int BuyingPrice { get; set; }
    }
}
