
/*String - till för test
    
    string firstName = "Miriam";
    var lastName = "Sporring";

string firstName = "Miriam";
var lastName = "Sporring";

string sentence = "Jag är \"bäst\" i hela världen";

//För att skriva url/uri-länkar finns två sätt att escapa \

//måste escapas string uri_1 = "c:\users\hans\document"; 
string uri_1 = "c:\\users\\hans\\document"; //1 - sätt framför \ i länken
string uri_2 = @"c:\users\hans\document"; //2 - sätt @ framför "c i länken
// urn betyder uniform resource name
// uri betyderuniform resource identifier

placeholders
string placeholder_1 = "Hej, jag heter " + firstName + " " + lastName + "."; //tidsödande
string placeholder_2 = $"Hej, jag heter {firstName} {lastName}."; // mer effektivt
string placeholder_3 = string.Format("Hej, jag heter {0} {1}.", firstName, lastName); // behövs egentligen inte men finns


Console.WriteLine(placeholder_1);
Console.WriteLine(placeholder_2);
Console.WriteLine(placeholder_3);
//Koden ovan fungerar, yes!


string firstName = "Miriam";
string email = "Miriam.Sporring@gmail.com";
Console.WriteLine($"Original: {email}");
Console.WriteLine($"ToUpper: {email.ToUpper()}");
Console.WriteLine($"ToLower: {email.ToLower()}");
Console.WriteLine();

string firstName = "Miriam ";
string lastName = "Sporring";
Console.WriteLine($"{firstName} {lastName}");
Console.WriteLine($"{firstName.Trim()} {lastName.Trim()}"); //användbart i t ex formulär, hämta data ur formulär
Console.WriteLine();

string sentence = "Här har vi en text som är på svenska.";
Console.WriteLine(sentence.Replace("ä", "a").Replace("å", "a"));
Console.WriteLine();

string name = "Miriam Sporring";
string domain = "gmail.com";
string emailadress = $"{name}@{domain}";
Console.WriteLine(emailadress);

emailadress = emailadress.Replace(" ", ".").ToLower();
Console.WriteLine(emailadress);


Summa summarum: Trim ToUpper To Lower Replace - användbara!!!

 */

/*
    INTEGRALS (heltalsvärden) & FLOATING POINTS (decimalvärden)
___________________________________________
        LAGRA HELTAL NEDAN
        Type        Bits        RANGE (min, max)
      * byte        8           0               255 För små värden, tar mindre plats
        sbyte       8           -128            127
        short       16          -32768          32767
        ushort      16          0               65535
      * int         32          - många         + många
        uint        32          0               + många
      * long        64          - jättemånga    + jättemånga
        ulong       64          0               + jättemånga

        int = 39;
        long = 39;

        LAGRA DECIMALTAL NEDAN
        Type        Bytes       DECIMAL RANGE       SUFFIX
        float       4           6-9 digits          f eller F - tar mindre plats                        
        double      8           15-16 digits        inget, d eller D
      * decimal     16          28-29 digits        m eller M


        float floatValue = 0.1f + 0.1f + 0.1f; //0.3
        Console.WriteLine(floatValue);

        double doubleValue = 0.1 + 0.1 + 0.1; //0.30000000004 ish
        Console.WriteLine(doubleValue);

        decimal decimalValue = 0.1m + 0.1m + 0.1m;
        Console.WriteLine(decimalValue);

        float = 1.123456789f;
        double = 1.123456789012345;
        decimal = 1.1234567890123456789012345678m;
*/

/*
        BOOLEAN - Sant/Falskt
        ________________________________________
        Type            Bits
        bool            0/1         false/true

    bool isEnabled = false;
    bool isActive = true;

*/

/*
    GUID/UUID   (Globally Unique Identifier)
    _______________________________________________________
    Guid            16  bytes       Guid.NewGuid();         jättemånga tecken, en lång sträng
        för att sätta unika id:n, skapa användare - Guid

    Guid userID = Guid.NewGuid();
    Console.WriteLine(userID);
*/
