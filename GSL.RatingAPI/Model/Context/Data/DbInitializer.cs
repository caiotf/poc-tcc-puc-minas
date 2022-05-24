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
                    DataAvalicao = System.DateTime.Now.AddDays(1).AddHours(5).AddMinutes(22),
                    UserId = "41f2f3c2-5744-4190-9862-a11b21d113a5",
                    UserName = "Alfa",
                    UserEmail = "alfa@alfa.com"

                },
                new Rating()
                {
                    AgilidadeNaEntrega = ERating.Ruim,
                    BoaComunicacao = ERating.MuitoBom,
                    CuidadoComMercadoria = ERating.Ruim,
                    DataAvalicao = System.DateTime.Now.AddDays(3).AddHours(2).AddMinutes(12),
                    UserId = "51a52c43-bb50-46f2-9f5c-c3a58642aaef",
                    UserName = "Beta",
                    UserEmail = "beta@beta.com"

                }
            };

            _context.Ratings.AddRange(ratings);
            _context.SaveChanges();
            #endregion Dados Iniciais Produtos  
        }
    }
}
