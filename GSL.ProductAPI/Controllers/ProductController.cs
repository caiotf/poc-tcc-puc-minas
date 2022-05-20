using GSL.ProductAPI.Data.ValueObjects;
using GSL.ProductAPI.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GSL.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        [AllowAnonymous]
        //[Authorize(Policy = "ApiUser")]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
        {
            var products = await _repository.FindAll();

            //if (User.HasClaim("user_roles", "apiAdmin"))
            //{
            //    return Ok(products.OrderBy(o => o.Customer));
            //}

            //var identity = HttpContext.User.Identity as ClaimsIdentity;
            //var userName = identity.FindFirst("name").Value;
            //var productsUser = products.Where(w => w.Customer == userName).OrderBy(o => o.Customer);

            return Ok(products);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = "ApiUser")]
        public async Task<ActionResult<ProductVO>> FindById(long id)
        {
            var product = await _repository.FindById(id);
            if (product == null) return NotFound();

            if (User.HasClaim("user_roles", "apiAdmin"))
            {
                return Ok(product);
            }

            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var userName = identity.FindFirst("name").Value;

            if (product.Customer == userName)
                return Ok(product);
            else
                return NotFound();

        }

        [HttpPost]
        [Authorize(Policy = "ApiAdmin")]
        public async Task<ActionResult<ProductVO>> Create([FromBody] ProductVO vo)
        {
            string accToken = HttpContext.GetTokenAsync("access_token").Result;
            string idToken = HttpContext.GetTokenAsync("id_token").Result;

            if (vo == null) return BadRequest();
            var product = await _repository.Create(vo);
            return Ok(product);
        }

        [HttpPut]
        [Authorize(Policy = "ApiAdmin")]
        public async Task<ActionResult<ProductVO>> Update([FromBody] ProductVO vo)
        {
            if (vo == null) return BadRequest();
            var product = await _repository.Update(vo);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = "ApiAdmin")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}
