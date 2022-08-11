using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    // Remember that an interace not contain any implementation logic, only signature of functionality
    {
        string CreateToken(AppUser user);
    }
}
