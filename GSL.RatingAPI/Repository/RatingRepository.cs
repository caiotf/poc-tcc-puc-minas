using AutoMapper;
using GSL.RatingAPI.Data.ValueObjects;
using GSL.RatingAPI.Model;
using GSL.RatingAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSL.RatingAPI.Repository
{
    public class RatingRepository : IRatingRepository
    {
        private readonly SqlServerContext _context;
        private IMapper _mapper;

        public RatingRepository(SqlServerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RatingVO>> FindAll()
        {
            List<Rating> ratings = await _context.Ratings.ToListAsync();
            return _mapper.Map<List<RatingVO>>(ratings);
        }

        public async Task<RatingVO> Create(RatingVO vo)
        {
            Rating rating = _mapper.Map<Rating>(vo);
            _context.Ratings.Add(rating);
            await _context.SaveChangesAsync();
            return _mapper.Map<RatingVO>(rating);
        }

        public async Task<RatingVO> FindById(string userId)
        {
            Rating rating =
                await _context.Ratings.Where(p => p.UserId == userId)
                .FirstOrDefaultAsync();
            return _mapper.Map<RatingVO>(rating);
        }

        public async Task<RatingVO> Update(RatingVO vo)
        {
            Rating rating = _mapper.Map<Rating>(vo);
            _context.Ratings.Update(rating);
            await _context.SaveChangesAsync();
            return _mapper.Map<RatingVO>(rating);
        }
    }
}
