using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Text;

namespace ParksAPI
{
  public class JwtAuthenticationManager : IJwtAuthenticationManager
  {
    private readonly IDictionary<string, string> users = new Dictionary<string, string>
    {{"testUser1", "password1"},{"testUser2","password2"}};
    private readonly string key;

    public JwtAuthenticationManager(string key)
    {
      this.key = key;
    }

    public string Authenticate(string username, string password)
    {
      if (!users.Any(e => e.Key == username && e.Value == password))
      {
        return null;
      }

      var tokenHandler = new JwtSecurityTokenHandler();
      var tokenKey = Encoding.ASCII.GetBytes(key);
      var tokenDescriptor = new SecurityTokenDescriptor()
      {
        Subject = new ClaimsIdentity(new Claim[]
        {
          new Claim(ClaimTypes.Name, username)
        }),
        Expires = DateTime.UtcNow.AddHours(1),
        SigningCredentials = 
        new SigningCredentials(
          new SymmetricSecurityKey(tokenKey),
          SecurityAlgorithms.HmacSha256Signature)
      };
      var token = tokenHandler.CreateToken(tokenDescriptor);
      return tokenHandler.WriteToken(token);
    }
  }
}