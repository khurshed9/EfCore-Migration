using Ef_Core.DataContext;
using Ef_Core.Entities;

namespace Ef_Core.Services;

public class UserService(ApplicationContext applicationContext) : IUserService
{
    public IEnumerable<User> GetUsers()
    {
        return applicationContext.Users.ToList();
    }

    public User? GetUserById(int id)
    {
        return applicationContext.Users.Find(id);
    }

    public bool CreateUser(User user)
    {
        if (user == null) return false;
        applicationContext.Users.Add(user);
        int res = applicationContext.SaveChanges();
        return res != 0;
    }

    public bool UpdateUser(User user)
    {
        User? existingUser = applicationContext.Users.Find(user.Id);
        if (existingUser == null) return false;
        existingUser.Name = user.Name;
        existingUser.Email = user.Email;
        existingUser.Age = user.Age;
        var res = applicationContext.SaveChanges();
        return res != 0;
    }

    public bool DeleteUser(int id)
    {
        User? user = applicationContext.Users.Find(id);
        if (user == null) return false;

        applicationContext.Users.Remove(user);
        int res = applicationContext.SaveChanges();
        return res != 0;
    }
}