using InventoryProject.Abstractions.Models;
using InventoryProject.Repository.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProject.Service.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(
            IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductDomainModel GetProductById(int id)
        {
            return new ProductDomainModel { ProductId = 5, ProductName = "Medicine", QuantityInStock = 10, BuyingPrice = 200 };
        }
    }
}