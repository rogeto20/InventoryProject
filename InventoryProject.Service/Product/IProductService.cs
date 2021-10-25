using InventoryProject.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProject.Service.Product
{
    public interface IProductService
    {
        ProductDomainModel GetProductById(int id);
    }
}
