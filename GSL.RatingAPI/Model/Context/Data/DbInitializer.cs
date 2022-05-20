using GSL.RatingAPI.Enuns;
using System.Linq;

namespace GSL.RatingAPI.Model.Context.Data
{
    public class DbInitializer
    {
        public static void Initialize(SqlServerContext _context)
        {
            #region Dados Iniciais Ratings  
            // Buscar cualquier artista
            if (_context.Ratings.Any())
                return;

            var ratings = new Rating[]
            {
                new Rating()
                {
                    AgilidadeNaEntrega = ERating.MuitoBom,
                    BoaComunicacao = ERating.MuitoBom,
                    CuidadoComMercadoria = ERating.MuitoBom,
                    DataAvalicao = System.DateTime.Now,
                    UserId = "1111",
                    UserName = "Alfa",
                    UserEmail = "alfa@alfa.com"

                },
                new Rating()
                {
                    AgilidadeNaEntrega = ERating.Ruim,
                    BoaComunicacao = ERating.MuitoBom,
                    CuidadoComMercadoria = ERating.Ruim,
                    DataAvalicao = System.DateTime.Now,
                    UserId = "2222",
                    UserName = "Alfa",
                    UserEmail = "alfa@alfa.com"

                },
                new Rating()
                {
                    AgilidadeNaEntrega = ERating.Bom,
                    BoaComunicacao = ERating.Ruim,
                    CuidadoComMercadoria = ERating.Bom,
                    DataAvalicao = System.DateTime.Now,
                    UserId = "3333",
                    UserName = "Beta",
                    UserEmail = "beta@alfa.com"
                },
            };

            _context.Ratings.AddRange(ratings);
            _context.SaveChanges();
            #endregion Dados Iniciais Produtos  
        }
    }
}
