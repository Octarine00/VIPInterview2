using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIPInterview.Data.Models;

namespace VIPInterview.Data.Services
{
    public class VIPInterviewDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
