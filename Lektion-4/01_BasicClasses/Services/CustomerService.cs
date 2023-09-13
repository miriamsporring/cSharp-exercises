using _01_BasicClasses.Models;

namespace _01_BasicClasses.Services;

internal
    private class CustomerService
{
    // fields - saker som lever bara inom den här klassen
    //private för att skydda dig och systemet

    private List<Customer> _costumerList;


    public void CreateCustomer(Customer customer)
    {
       if (!_costumerList.Contains(customer))
        _costumerList.Add(customer);
    }

    public List<Customer> GetCustomers()
    {
        return _costumerList.OrderBy(x => x.Id).ToList();

    }






    //Methods(propertyName)
    public void CreateCustomer(Customer customer) { }
    public void GetCustomer() { }


     


    public void UpdateCustomer() { }
    public void DeleteCustomer() { }

    internal void CreateCustomers(Customer customer)
    {
        throw new NotImplementedException();
    }
}





// service = 90 % Methods - all funktionalitet i serviceklassen
//metoder affärslogiken, att skapa   







/*internal class CustomerService
{
    //fields
    //private  - bara inom det här scopet är den tillgänglig
    private List<Customer> _customerList;


    //Methods (propertyName)

    public void CreateCustomer(Customer customer) { } 
    public void GetCustomer() { }

    public List<Customer> GetCustomers()
    {
        return _customerList;
    }
    public void UpdateCustomer () { }
    public void DeleteCustomer () { }   

}*/
