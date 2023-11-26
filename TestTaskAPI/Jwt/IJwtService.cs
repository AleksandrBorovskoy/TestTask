using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace TestTaskAPI.Jwt
{
    public interface IJwtService
    {
        string Generate(int id);
        JwtSecurityToken Verify(string jwt);
    }
}
