using GSL.RatingAPI.Enuns;
using GSL.RatingAPI.Model.Base;
using System.ComponentModel.DataAnnotations;

namespace GSL.RatingAPI.Model
{
    public class Rating : BaseEntity
    {
        [Required]
        public ERating AgilidadeNaEntrega { get; set; }
        [Required]
        public ERating Transparencia { get; set; }
        [Required]
        public ERating BoaComunicacao { get; set; }
        [Required]
        public ERating CuidadoComMercadoria { get; set; }
        public int IdUser { get; set; }
    }
}
