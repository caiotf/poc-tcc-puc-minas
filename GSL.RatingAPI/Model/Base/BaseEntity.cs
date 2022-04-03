using System.ComponentModel.DataAnnotations;

namespace GSL.RatingAPI.Model.Base
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
