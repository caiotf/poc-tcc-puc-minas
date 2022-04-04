using GSL.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GSL.Web.Services.IServices
{
    public interface IRatingService
    {
        Task<IEnumerable<RatingModel>> FindAllRatings(string token);
        Task<RatingModel> CreateRating(RatingModel model, string token);
        Task<RatingModel> FindRatingByUserId(string userId, string token);
        Task<RatingModel> UpdateRating(RatingModel model, string token);
    }
}
