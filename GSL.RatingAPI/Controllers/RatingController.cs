using GSL.RatingAPI.Data.ValueObjects;
using GSL.RatingAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GSL.RatingAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private IRatingRepository _repository;

        public RatingController(IRatingRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        //[Authorize(Policy = "ApiUser")]
        public async Task<ActionResult<IEnumerable<RatingVO>>> FindAll()
        {
            var products = await _repository.FindAll();
            return Ok(products);
        }

        [HttpPost]
        //[Authorize(Policy = "ApiAdmin")]
        public async Task<ActionResult<RatingVO>> Create([FromBody] RatingVO vo)
        {
            if (vo == null) return BadRequest();
            var rating = await _repository.Create(vo);
            return Ok(rating);
        }
    }
}
