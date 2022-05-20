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
                        CategoryName = "Eletrot",
                        Customer = "Alfa",
                        Stock = 50
                },
            };

            _context.Products.AddRange(products);
            _context.SaveChanges();
            #endregion Dados Iniciais Produtos  

            #region Dados Iniciais Rating
            //// Buscar cualquier album
            //if (_context.Albumes.Any())
            //    return;

            //var albumes = new Album[]
            //{
            //    new Album()
            //    {
            //        ArtistaID = _context.Artistas.FirstOrDefault(a => a.Nombre.Equals("Luis Miguel")).ArtistaID,
            //        Titulo = "Romance",
            //        Anio = 1991,
            //        Precio = 180
            //    },
            //    new Album()
            //    {
            //        ArtistaID = _context.Artistas.FirstOrDefault(a => a.Nombre.Equals("Ricardo Arjona")).ArtistaID,
            //        Titulo = "Circo Soledad",
            //        Anio = 2017,
            //        Precio = 190
            //    },
            //    new Album()
            //    {
            //        ArtistaID = _context.Artistas.FirstOrDefault(a => a.Nombre.Equals("Kalimba")).ArtistaID,
            //        Titulo = "Aerosoul",
            //        Anio = 2004,
            //        Precio = 210
            //    }
            //};

            //_context.Albumes.AddRange(albumes);
            //_context.SaveChanges();
            #endregion Datos Iniciales de Albumes
        }
    }
}
