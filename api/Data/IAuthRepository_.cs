using System.Threading.Tasks;
using api.Model;

namespace api.Data
{
    public interface IAuthRepository
    {
         Task<Employees> Register(Employees user , string password);
         Task<Employees> Login(string username , string password);
         Task<bool> EmployeeExists(string username);
    }
}