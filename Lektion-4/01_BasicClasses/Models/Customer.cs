namespace _01_BasicClasses.Models;

internal class Customer
{
       //model = 90 % Properties
       //Properties - hur ser kunden ut
       //public + datatyp + namn

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

}
