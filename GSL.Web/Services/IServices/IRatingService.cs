using GSL.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GSL.Web.Services.IServices
{
    public interface IRatingService
    {
        Task<IEnumerable<RatingModel>> FindAllRatings();
        Task<RatingModel> CreateRating(RatingModel model);
        Task<RatingModel> FindRatingByUserId(string userId);
        Task<RatingModel> UpdateRating(RatingModel model);
    }
}
