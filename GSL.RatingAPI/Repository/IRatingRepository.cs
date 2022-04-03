using GSL.RatingAPI.Data.ValueObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GSL.RatingAPI.Repository
{
    public interface IRatingRepository
    {
        Task<IEnumerable<RatingVO>> FindAll();
        Task<RatingVO> Create(RatingVO vo);
        Task<RatingVO> FindById(string userId);
        Task<RatingVO> Update(RatingVO vo);
    }
}
