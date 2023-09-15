
using System.Text;
using _02_Classes_Classes_GettersAndSetters;
using _02_Classes_Classes_GettersAndSetters.Models;

var customer = new Customer();

// set - sätt ett värde
customer.FirstName = "Miriam ";
customer.LastName = "Sporring";

//get - hämta värdet
var name = customer.FullName;
Console.WriteLine(name);


var user = new User();
user.FirstName = "Miriam";
user.LastName = "Sporring";
user.Email = " Miriam.sporring@domain.com";

user.SetSecurePassword("BytMig 123");
var password = Encoding.UTF8.GetString(user.Password);
Console.WriteLine($"password: {password} \n");

user.Password = Encoding.UTF8.GetBytes(MirresMagiskaLösenord);
Console.WriteLine($"password: {password}");
Console.ReadKey();

//Släpper den här delen nu, lösenord kommer senare, inte i den här uppgiften


























/*using _02_Classes_Classes_GettersAndSetters.Models;

var customer = new Customer();

//set - sätt ett värde
customer.FirstName = "Miriam";
customer.LastName = "Sporring";

//get - hämta värdet
var name = customer.FullName;
Console.WriteLine(name);

var user  = new User();
user.FirstName = "Miriam";
user.LastName = "Sporring";
user.Email = "Miriam.sporring@domain.com";



public void SetSecurePassword =(string password)

var password = user.Password.ToString();
Console.WriteLine($"Password: {password}");

*/