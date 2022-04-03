using System;
using System.IdentityModel.Tokens.Jwt;

namespace GSL.Web.Utils
{
    public class AccToken
    {
        public static bool IsExpiredAccToken(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                return true;
            }

            var jwtToken = new JwtSecurityToken(token);
            return (jwtToken == null) || (jwtToken.ValidFrom > DateTime.UtcNow) || (jwtToken.ValidTo < DateTime.UtcNow);
        }
    }
}
