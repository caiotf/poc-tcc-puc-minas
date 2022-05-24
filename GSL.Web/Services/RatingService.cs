using GSL.Web.Models;
using GSL.Web.Services.IServices;
using GSL.Web.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GSL.Web.Services
{
    public class RatingService : IRatingService
    {
        private readonly HttpClient _client;
        public const string BasePath = "gateway/rating";

        public RatingService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<RatingModel>> FindAllRatings(string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<RatingModel>>();
        }

        public async Task<RatingModel> CreateRating(RatingModel model, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.PostAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<RatingModel>();
            else throw new Exception("Something went wrong when calling API");
        }

        public async Task<RatingModel> FindRatingByUserId(string userId, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.GetAsync($"{BasePath}/{userId}");
            return await response.ReadContentAs<RatingModel>();
        }

        public async Task<RatingModel> UpdateRating(RatingModel model, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.PutAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<RatingModel>();
            else throw new Exception("Something went wrong when calling API");
        }
    }
}
