using System.Linq.Expressions;
using _01_Exercise.Models;

namespace _01_Exercise.Interfaces; //som ett kontrakt

internal interface IUserService
{
    public void Create(UserCreateRequest userCreateRequest); //metod, bara skapa - Create
    public User Get(Func<User, bool> expression); //lambda expr. specificera upp vad jag vill, hämta användare - User
//    public User Get(Expression<Func<User, bool>> expression);
    public IEnumerable<User> GetAll(); //hämta, ger en läsbar lista, sortera och se innehållet -GetAll
     

}
