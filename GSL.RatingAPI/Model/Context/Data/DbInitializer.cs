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
                    UserId = "41f2f3c2-5744-4190-9862-a11b21d113a5",
                    UserName = "Alfa",
                    UserEmail = "alfa@alfa.com"

                },
                new Rating()
                {
                    AgilidadeNaEntrega = ERating.Ruim,
                    BoaComunicacao = ERating.MuitoBom,
                    CuidadoComMercadoria = ERating.Ruim,
                    DataAvalicao = System.DateTime.Now,
                    UserId = "51a52c43-bb50-46f2-9f5c-c3a58642aaef",
                    UserName = "Alfa",
                    UserEmail = "alfa@alfa.com"

                },
                new Rating()
                {
                    AgilidadeNaEntrega = ERating.Bom,
                    BoaComunicacao = ERating.Ruim,
                    CuidadoComMercadoria = ERating.Bom,
                    DataAvalicao = System.DateTime.Now,
                    UserId = "618acb52-37e6-460a-befe-b8bcee29ae5a",
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
