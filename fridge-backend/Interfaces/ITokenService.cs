using DefaultNamespace;

namespace fridge_backend.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}