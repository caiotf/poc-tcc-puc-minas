using AutoMapper;
using GSL.RatingAPI.Data.ValueObjects;
using GSL.RatingAPI.Model;

namespace GSL.RatingAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<RatingVO, Rating>();
                config.CreateMap<Rating, RatingVO>();
            });
            return mappingConfig;
        }
    }
}
