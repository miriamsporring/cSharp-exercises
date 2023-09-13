
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
user.Password = "BytMig123";



























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