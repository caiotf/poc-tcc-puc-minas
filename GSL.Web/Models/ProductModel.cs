using System.Collections.Generic;

namespace GSL.Web.Models
{
    public class ProductModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }
        public string Customer { get; set; }
        public int Stock { get; set; }

        //TODO: get from db
        public List<string> Categories = new List<string> { "Eletro", "Moveis", "Telefonia" };
        public List<string> Customers = new List<string> { "Alfa", "Beta", "Delta" };
    }
}
