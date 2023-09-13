using _03_Classes_Constructions.Models;

var customer_1;  new Customer(customer_1);

var customer_2 = new Customer(); //om något objekt ska uppdateras
customer_2.Id = 1;
customer_2.Name = "Miriam Sporring";
customer_2.Email = "miriam.sporring@domain.com";
customer_2.phoneNumber = "12345789";

var customer_3 = new Customer() //bra om man bara ska mata in
{
    Id = 1,
    Name = "Miriam Sporring",
    Email = "miriam.sporring@domain.com";
    phoneNumber = "12456789";
};



var customer_4 = new Customer("Miriam Sporring", "miriam@domain.com");

var = new Customer();

