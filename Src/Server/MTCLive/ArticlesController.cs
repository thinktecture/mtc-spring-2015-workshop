using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MTCLive
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class ArticlesController : ApiController
    {
        [ActionName("ping")]
        public string GetPing()
        {
            return "OK";
        }

        [ActionName("item")]
        public Product GetProduct()
        {
            return  new Product{Id = 42, Title = "Eh klar..."};
        }
    }
}
