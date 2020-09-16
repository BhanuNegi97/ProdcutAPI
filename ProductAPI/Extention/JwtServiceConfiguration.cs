using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;


namespace ProductAPI.Extention
{
    public static class JwtServiceConfiguration
    {
        public static void AddJWTServices(this IServiceCollection services, IConfiguration _configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
              .AddJwtBearer(options =>
              {
                  options.TokenValidationParameters = new TokenValidationParameters
                  {
                      ValidateIssuerSigningKey = true,
                      IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.ASCII
                          .GetBytes(_configuration.GetSection("Token").Value)),
                      ValidateIssuer = false,
                      ValidateAudience = false
                  };
              });
        }
    }
}
