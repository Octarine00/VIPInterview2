using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIPInterview.Data.Models;

namespace VIPInterview.Data.Services
{
    public interface IProductData
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
