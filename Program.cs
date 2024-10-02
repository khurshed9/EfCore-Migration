


using Ef_Core.DataContext;
using Ef_Core.Entities;
using Ef_Core.Services;

IUserService userService = new UserService(new ApplicationContext());

/*
userService.CreateUser(new User{Name = "John", Email = "john@example.com",Age = 28});
userService.CreateUser(new User{Name = "Tom", Email = "tom@example.com",Age = 14});
userService.CreateUser(new User{Name = "Ben", Email = "ben@example.com",Age = 19});
userService.CreateUser(new User{Name = "Maks", Email = "maks@example.com",Age = 35});
*/

Thread.Sleep(3000);

IEnumerable<User> users = userService.GetUsers();
foreach (var user in users)
{
    Console.WriteLine(user.Id + " " + user.Name + " " + user.Email + " " + user.Age);
}

Console.WriteLine("----------------------------------------------------------------");


User? userById = userService.GetUserById(2);

Console.WriteLine(userById.Id + " " + userById.Name + " " + " " + userById.Email + " " + userById.Age);

Console.WriteLine("----------------------------------------------------------------");

userService.UpdateUser(new User{Id = 4,Name = "Frola",Email = "frola@gmail.com",Age = 44});
Console.WriteLine("Updating user by Id...");
Thread.Sleep(3000);

IEnumerable<User> afterupdate = userService.GetUsers();
foreach (var get in afterupdate)
{
    Console.WriteLine(get.Id + " " + get.Name + " " + get.Email + " " + get.Age);
}

Console.WriteLine("----------------------------------------------------------------");

userService.DeleteUser(1);
Console.WriteLine("Deleting user by Id...");
Thread.Sleep(3000);

IEnumerable<User> getUsers = userService.GetUsers();
foreach (var getUser in getUsers)
{
    Console.WriteLine(getUser.Id + " " + getUser.Name + " " + getUser.Email + " " + getUser.Age);
}