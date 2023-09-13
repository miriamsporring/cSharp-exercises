
using _01_BasicClasses.Models;
using _01_BasicClasses.Services;

/* 
 
    Access Modifiers - BEHÖVER KUNNA, om osäker, använd public, inte alltid det bästa
    _______________________
    private         accesbara bara inom scopet (dvs {}) som variabeln ligger inom.
    public          accessbara överallt i hela din solution, dvs även mellan olika projekt
    internal        aceessbar överallt i hela ditt projekt, men inte mellan olika projekt

 */


// Vi gör en instans av en customerService så vi kan använda den
var customerService = new CustomerService();

customerService.CreateCustomers(new Customer { });
//var list = customerService._customerList;


































/*using _01_BasicClasses.Services;

    //Vi gör en instans av en customerService så vi kan använda den

/* 
    Access Modifiers - SKA KUNNA
    ___________________________-
    private         accessbara bara inom scopet (dvs { }) som variabeln ligger inom.
    public          accessbar överallt i hela din solution, dvs även mellan olika projekt
    internal        accessbar överallt i hela ditt projekt, men inte mellan olika projekt

 
 */


/*var customerService = new CustomerService();

customerService.GetCustomers();*/