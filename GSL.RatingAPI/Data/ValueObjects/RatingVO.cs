using GSL.RatingAPI.Enuns;
using System;

namespace GSL.RatingAPI.Data.ValueObjects
{
    public class RatingVO
    {
        public int Id { get; set; }
        public ERating AgilidadeNaEntrega { get; set; }
        public ERating BoaComunicacao { get; set; }
        public ERating CuidadoComMercadoria { get; set; }
        public DateTime DataAvalicao { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
    }
}
