using System;
using System.Collections.Generic;
using System.Linq;
using VIPInterview.Data.Models;

namespace VIPInterview.Data.Services
{
    public class InMemoryProductData : IProductData
    {
        List<Product> products;
        public InMemoryProductData()
        {
            products = new List<Product>()
            {
            new Product { ID = 1, Name = "Graphics Card", Price = 20}, 
            new Product { ID = 2, Name = "Mouse", Price = 30.5m },
            new Product { ID = 3, Name = "Motherboard", Price = 40 }, 
            new Product { ID = 4, Name = "Processor", Price = 60 },
            new Product { ID = 5, Name = "Keyboard", Price = 65 },
            new Product { ID = 6, Name = "HDMI Cable", Price = 90.25m }
            };
        }

        public void Add(Product product)
        {
            products.Add(product);
            product.ID = products.Max(p => p.ID) + 1;
        }

        public void Update(Product product)
        {
            var existingproduct = Get(product.ID);
            if(existingproduct != null)
            {
                existingproduct.Name = product.Name;
                existingproduct.Price = product.Price;
            }
        }

        public Product Get(int id)
        {
            return products.FirstOrDefault(p => p.ID == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return products.OrderBy(o => o.Name);     
        }

        public void Delete(int id)
        {
            var product = Get(id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}
