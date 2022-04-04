using GSL.RatingAPI.Data.ValueObjects;
using GSL.RatingAPI.Repository;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Policy = "ApiUser")]
        public async Task<ActionResult<IEnumerable<RatingVO>>> FindAll()
        {
            var rating = await _repository.FindAll();
            return Ok(rating);
        }

        [HttpPost]
        [Authorize(Policy = "ApiUser")]
        public async Task<ActionResult<RatingVO>> Create([FromBody] RatingVO vo)
        {
            if (vo == null) return BadRequest();
            var rating = await _repository.Create(vo);
            return Ok(rating);
        }

        [HttpGet("{userId}")]
        [Authorize(Policy = "ApiUser")]
        public async Task<ActionResult<RatingVO>> FindById(string userId)
        {
            var rating = await _repository.FindById(userId);
            if (rating == null) return NotFound();
            return Ok(rating);
        }

        [HttpPut]
        [Authorize(Policy = "ApiUser")]
        public async Task<ActionResult<RatingVO>> Update([FromBody] RatingVO vo)
        {
            if (vo == null) return BadRequest();
            var rating = await _repository.Update(vo);
            return Ok(rating);
        }
    }
}
