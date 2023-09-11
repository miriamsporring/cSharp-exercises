/* Lists
   ______________________________________________
    En lista är en dynamisk lista som gör att det går att lägga till och 
    ta bort objekt ifrån listan. Det går även att sortera om den.
    Det finns lite olika typer av listor för olika ändamål.
    
    Instansiera en ny lista:
    ________________________________

    
    List<int> list = new List<int>();
    var list = new List<string>();
    List<int> list = new();
    
    List<>                  ReadWrite           lägga till, ta bort, sortera, insert
    IEnumerable<>           Read                sortera vid databasanrop
    ICollection<>           ReadWrite           lägga till, tab bort, sortera
    ObservableCollection    

    * I betyder Interface och har då en uppsättning av funktioner vi kan
      komma åt och göra något med.

    using System.Collections.ObjectModel; //sökvägar till olika delar i .NET-biblioteket

    List<string> list_1 = new List<string>();
    list_1.Add("1");
    list_1.Remove("1");
    list_1.OrderByDescending(x => x);
    list_1.Clear();
    list_1.FirstOrDefault();
    list_1.LastOrDefault(); 
    list_1.Insert(0, "1");

    IEnumerable<string> list_2 = new List<string>();
    list_2.Add("1");
    list_2.Remove("1");
    list_2.OrderByDescending(x => x);
    list_2.Clear();
    list_2.FirstOrDefault();
    list_2.LastOrDefault();
    list_2.Insert(0, "1");

    ICollection<string> list_3 = new List<string>();
    list_3.Add("1");
    list_3.Remove("1");
    list_3.OrderByDescending(x => x);
    list_3.Clear();
    list_3.FirstOrDefault();
    list_3.LastOrDefault();
    list_3.Insert(0, "1");

    ObservableCollection<string> list_4 = new List<string>(); //i grafiska gränssnitt
    list_4.Add("1");
    list_4.Remove("1");
    list_4.OrderByDescending(x => x);
    list_4.Clear();
    list_4.FirstOrDefault();
    list_4.LastOrDefault();
    list_4.Insert(0, "1");

    var names = new List<string>();

    names.Add("Paula");
    names.Add("Miriam");
    names.Add("Sara");

    foreach(var name in names)
    {
        Console.WriteLine(name);
    }
    Console.WriteLine();

    var user = names.FirstOrDefault(name => name.ToLower() == "paula");
    if (user != null)
        Console.WriteLine(user);
    else
        Console.WriteLine("Användaren hittades inte.");

*/

/* Classes
    ________________________________________
    Klasser är en del av objektorienterad programmering (C#).
    En klass är alltså ett objekt och en klass kan innehålla flera olika saker.
    Se en klass som en mall över hur något ser ut eller hur något är.

    en användare, en kund, en order, en produkt, en prislista, en adress 
    ett kontaktformulär, 

    class ContactPerson
    {
        //Properties och skrivs med Pascal
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }   
        public string PhoneNumber { get; set; }   

    }
 */



using _04_.Models;

var contactPersons = new List<ContactPerson>();
var answer = "n";


do
{
    Console.Clear();

    //skapar en kontaktperson
    var contactPerson = new ContactPerson();

    Console.Write("Förnamn: ");
    contactPerson.FirstName = Console.ReadLine() ?? "";

    Console.Write("Efternamn: ");
    contactPerson.LastName = Console.ReadLine() ?? "";

    Console.Write("Email: ");
    contactPerson.Email = Console.ReadLine() ?? "";

    Console.Write("Telefonnummer: ");
    contactPerson.PhoneNumber = Console.ReadLine() ?? "";

    //Lägger till kontaktpersonen till listan
    contactPersons.Add(contactPerson);

    Console.Write("Vill du lägga till en till person? (y/n): ");
    answer = Console.ReadLine();

} while (answer.ToLower() == "y");

Console.Clear();
Console.WriteLine("Här är alla kontaktpersoner: ");
foreach(var contact in contactPersons)
{
    Console.WriteLine($"{contact.FirstName} {contact.LastName} <{contact.Email}>");
}