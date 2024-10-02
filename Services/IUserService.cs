using Ef_Core.Entities;

namespace Ef_Core.Services;

public interface IUserService
{
    IEnumerable<User> GetUsers();
    
    User? GetUserById(int id);

    bool CreateUser(User user);
    
    bool UpdateUser(User user);
    
    bool DeleteUser(int id);
}