using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _03_Classes_Constructions.Models;

internal class Customer //En modell med tre egenskaper
{

    //ctor + 2 tabb = skapar en tom constructor, en tom ska alltid finnas med
    public Customer() 
    {
        Name = "";
        Email = null!;
        PhoneNumber = "";
    }

    public Customer(string name) //parametrar, camel-case
    {
        Name = name;
        Email = "";
        PhoneNumber = "";
    }
    public Customer(string name, string email) //parametrar, camel-case
    {
        Name = name;
        Email = email;
        PhoneNumber = "";
    }
    public Customer(string name, string email, string phoneNumber) //parametrar, camel-case
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }


    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}

