using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Net.Sockets;

using _05_Classes_Inheritance.Models;
using _05_Classes_Inheritance.Services;
/*
var customer = new Customer() //inte bra
{
    Id = Guid.NewGuid(),
    Created = DateTime.Now,
    Modified = DateTime.Now,
    Email = "miriam.sporring@domain.com",

    FirstName = "Miriam",
    LastName = "Sporring",
    PhoneNumber = "1234567890",

};

var privateCustomer = new PrivateCustomer()
    {
        Id = Guid.NewGuid(),
        Created = DateTime.Now,
        Modified = DateTime.Now,
        Email = "miriam.sporring@domain.com",

        FirstName = "Miriam",
        LastName = "Sporring",
        PhoneNumber = "1234567890",

    };

var companyCustomer = new CompanyCostumer()
{
    Id = Guid.NewGuid(),
    Created = DateTime.Now,
    Modified = DateTime.Now,
    Email = "miriam.sporring@domain.com",

    CompanyName = "Nackademin",
    PhoneNumber = "1234567890",

};*/

Console.Write("Vad för typ av kund vill du skapa (p = privatperson, f= företag)");
var option = Console.ReadLine();

switch (option?.ToLower())
{
    case "p":
        CustomerService.CreatePrivateCustomer();
        break;

    case "f":
        CustomerService.CreateCompanyCustomer();
        break;

    default: 
        break;

}





