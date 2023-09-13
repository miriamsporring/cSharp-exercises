using System.Linq.Expressions;
using _01_Exercise.Interfaces;
using _01_Exercise.Models;

namespace _01_Exercise.Services;
internal class UserService : IUserService
    
{
    private List<User> _users = new List<User>();


    public void Create(UserCreateRequest userCreateRequest) //hur
    {
        _users.Add(new User
        {
            Id = Guid.NewGuid(),
            FirstName = userCreateRequest.FirstName,
            LastName = userCreateRequest.LastName,
            Email = userCreateRequest.Email
        });

        // Lösenordet får vi hantera separat, av säkerhetsskäl...
    }

    public User Get(Func<User, bool> expression)
    {
        var user = _users.FirstOrDefault(expression, null!);
        //if (user != null)
            return user;
    }


    //public User Get(Expression<Func<User, bool>> expression)
    //{

    //    throw new NotImplementedException ();
    //}

    public IEnumerable<User> GetAll()
    {
        return _users;
    }
}
