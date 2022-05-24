using System.Linq;

namespace GSL.ProductAPI.Model.Context.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SqlServerContext _context)
        {
            #region Dados Iniciais Produtos  
            // Buscar cualquier artista
            if (_context.Products.Any())
                return;

            var products = new Product[]
            {
                new Product()
                {
                        Name = "Geladeira",
                        Price = new decimal(2500),
                        Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                        ImageURL = "",
                        CategoryName = "Eletro",
                        Customer = "Alfa",
                        Stock = 22
                },
                new Product()
                {
                        Name = "Fogão",
                        Price = new decimal(500),
                        Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                        ImageURL = "",
                        CategoryName = "Eletro",
                        Customer = "Alfa",
                        Stock = 50
                },
                new Product()
                {
                        Name = "Liquidificador",
                        Price = new decimal(85),
                        Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                        ImageURL = "",
                        CategoryName = "Eletro",
                        Customer = "Beta",
                        Stock = 74
                },
                new Product()
                {
                        Name = "Liquidificador",
                        Price = new decimal(64),
                        Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                        ImageURL = "",
                        CategoryName = "Eletro",
                        Customer = "Delta",
                        Stock = 74
                },
                new Product()
                {
                        Name = "IPhone",
                        Price = new decimal(85),
                        Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                        ImageURL = "",
                        CategoryName = "Telefonia",
                        Customer = "Delta",
                        Stock = 74
                },
                new Product()
                {
                        Name = "Moto G5",
                        Price = new decimal(85),
                        Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                        ImageURL = "",
                        CategoryName = "Telefonia",
                        Customer = "Alfa",
                        Stock = 74
                },
                new Product()
                {
                        Name = "Mesa",
                        Price = new decimal(85),
                        Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                        ImageURL = "",
                        CategoryName = "Moveis",
                        Customer = "Beta",
                        Stock = 74
                },
                new Product()
                {
                        Name = "Guarda-roupa",
                        Price = new decimal(85),
                        Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                        ImageURL = "",
                        CategoryName = "Moveis",
                        Customer = "Delta",
                        Stock = 74
                }
            };

            _context.Products.AddRange(products);
            _context.SaveChanges();
            #endregion Dados Iniciais Produtos  
        }
    }
}
