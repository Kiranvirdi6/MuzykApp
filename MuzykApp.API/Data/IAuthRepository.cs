using System.Threading.Tasks;
using MuzykApp.API.Models;

namespace MuzykApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username,string password);
         Task<bool> UserExists(string username);

    }
}