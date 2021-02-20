using System;
using System.Collections.Generic;
using Generics.Common;
using Generics.Common.Interface;

namespace Generics.Repository.ProductRepository
{
    public class ProductServiceRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product newProduct)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int productId, Product updatedProduct)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProducts(IEnumerable<Product> updatedProducts)
        {
            throw new NotImplementedException();
        }
    }
}
