using System.Threading.Tasks;
using api.Model;

namespace api.Data
{
    public interface IUserRepository
    {
         Task<User> GetUser(int id);
    }
}