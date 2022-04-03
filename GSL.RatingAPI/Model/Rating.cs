using GSL.RatingAPI.Enuns;
using GSL.RatingAPI.Model.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace GSL.RatingAPI.Model
{
    public class Rating : BaseEntity
    {
        [Required]
        public ERating AgilidadeNaEntrega { get; set; }
        [Required]
        public ERating BoaComunicacao { get; set; }
        [Required]
        public ERating CuidadoComMercadoria { get; set; }
        [Required]
        public DateTime DataAvalicao { get; set; }
        [Required]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
    }
}
