using GSL.RatingAPI.Enuns;

namespace GSL.RatingAPI.Data.ValueObjects
{
    public class RatingVO
    {
        public int Id { get; set; }
        public ERating AgilidadeNaEntrega { get; set; }
        public ERating Transparencia { get; set; }
        public ERating BoaComunicacao { get; set; }
        public ERating CuidadoComMercadoria { get; set; }
        public int IdUser { get; set; }
    }
}
