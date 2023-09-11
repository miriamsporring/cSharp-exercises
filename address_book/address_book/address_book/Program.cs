using address_book;

var adressPersons = new List<AddressPerson>();
var answer = "n";


do
{
    Console.Clear();

    //skapar en kontaktperson
    var addressPerson = new AddressPerson();

    Console.Write("Förnamn: ");
    addressPerson.FirstName = Console.ReadLine() ?? "";

    Console.Write("Efternamn: ");
    addressPerson.LastName = Console.ReadLine() ?? "";

    Console.Write("Email: ");
    addressPerson.Email = Console.ReadLine() ?? "";

    Console.Write("Telefonnummer: ");
    addressPerson.PhoneNumber = Console.ReadLine() ?? "";


    //Lägger till kontaktpersonen till listan
    addressPersons.Add(addressPerson);

    Console.Write("Vill du lägga till en till person? (y/n): ");
    answer = Console.ReadLine();

} while (answer.ToLower() == "y");

Console.Clear();
Console.WriteLine("Här är alla kontaktpersoner: ");
foreach (var contact in adressPersons)
{
    Console.WriteLine($"{contact.FirstName} {contact.LastName} <{contact.Email}>");
}
