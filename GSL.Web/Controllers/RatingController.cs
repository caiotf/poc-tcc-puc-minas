using GSL.Web.Models;
using GSL.Web.Services.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GSL.Web.Controllers
{
    public class RatingController : Controller
    {
        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService ?? throw new ArgumentNullException(nameof(ratingService));
        }

        public async Task<IActionResult> RatingIndex()
        {
            string accToken = HttpContext.GetTokenAsync("access_token").Result;

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var rating = await _ratingService.FindAllRatings();
            var ratingUser = rating.Where(w => w.UserId == userId);

            if (ratingUser == null || !ratingUser.Any())
            {
                return RedirectToAction("RatingCreate");
            }

            return View(ratingUser);
        }

        public async Task<IActionResult> RatingCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RatingCreate(RatingModel model)
        {
            string accToken = HttpContext.GetTokenAsync("access_token").Result;

            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;
                string userEmail = userClaims?.FindFirst(System.Security.Claims.ClaimTypes.Email)?.Value;
                string userName = userClaims?.Name;

                model.UserId = userId;
                model.UserName = userName;
                model.UserEmail = userEmail;
                model.DataAvalicao = DateTime.Now;

                var response = await _ratingService.CreateRating(model);
                if (response != null) return RedirectToAction(
                     nameof(RatingIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> RatingUpdate()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            string accToken = HttpContext.GetTokenAsync("access_token").Result;

            var model = await _ratingService.FindRatingByUserId(userId);
            if (model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> RatingUpdate(RatingModel model)
        {
            string accToken = HttpContext.GetTokenAsync("access_token").Result;

            if (ModelState.IsValid)
            {
                model.DataAvalicao = DateTime.Now;
                var response = await _ratingService.UpdateRating(model);
                if (response != null) return RedirectToAction(
                     nameof(RatingIndex));
            }
            return View(model);
        }
    }
}