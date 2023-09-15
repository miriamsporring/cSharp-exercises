using _03_Classes_Constructions.Models;

var customer_1 = new Customer();

var customer_2 = new Customer(); //bra när man ska uppdatera ett objekt
customer_2.Id = 1;
customer_2.Name = "Mirre";
customer_2.Email = "mirre@domain.com";
customer_2.PhoneNumber = "1234567890";

var customer_3 = new Customer() //skapa ett nytt objekt, rekommenderas
{
    Id = 1,
    Name = "Mirre",
    Email = "mirre@domain.com",
    PhoneNumber = "1234567890",
};

//Tredje sättet gör i i vår klass, se Customer.cs

customer_4 = new Customer("Mirre Sporring", "mirre@domain.com", "123456789");

