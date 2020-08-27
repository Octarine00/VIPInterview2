using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIPInterview.Data.Models;

namespace VIPInterview.Data.Services
{
    public class SqlProductData : IProductData
    {

        private readonly VIPInterviewDbContext db;

        public SqlProductData(VIPInterviewDbContext db)
        {
            this.db = db;
        }
        public void Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
        }

        public Product Get(int id)
        {
            return db.Products.FirstOrDefault(p => p.ID == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products.OrderBy(p => p.Name);
        }

        public void Update(Product product)
        {
            var entry = db.Entry(product);
            entry.State = EntityState.Modified;           
            db.SaveChanges();
        }
    }
}
