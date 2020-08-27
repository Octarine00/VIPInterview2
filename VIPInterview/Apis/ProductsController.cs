using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VIPInterview.Data.Models;
using VIPInterview.Data.Services;

namespace VIPInterview.Apis
{
    public class ProdcutsController : ApiController
    {
        private readonly IProductData db;
        public ProdcutsController(IProductData db)
        {
            this.db = db;
        }

        public IEnumerable<Product> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}
