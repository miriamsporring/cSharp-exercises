
/* 
    OPERANDER
    _____________________________________
    ==      lika med
    !=      inte lika med
    <       mindre än
    >       större än
    <=      mindre än eller lika med
    >=      större än eller lika med
    &&      och
    ||      eller
    !       inte
    ??      om första värdet är null, välj det andra
    
 
    


*/

/*ARRAYS
   _____________________________________________
    En array är en statisk lista med fixerat antal platser som 
    man varken kan lägga till nya eller ta bort men det går att
    byta ut informationen i en specifik plats.

string[names = new string[] { "Paula", "Sara", "Simon", "Mattias" };
string[] names = new string[10];
names[0] = "Paula";

names[4] = "Mattias";

names[9] = "Simon";*/

/* IF-satser
    _____________________________________
 if (statement) {}
   
    if (statement) {} else {}

    if (statement) {} else if {} else {}

    (statement) ? do_this : else_do_this;


 


string name = "Miriam";
string firstName = "Sara"; 

if (!(name == firstName))
{
    Console.WriteLine("Namnen är lika.");
}
else
{
    Console.WriteLine("Namnen är inte lika.");
}

string firstName = "";

if (!string.IsNullOrEmpty(firstName)); //kollar om firstName är tom eller inte
{
    Console.WriteLine("Nu gör vi nåt med förnamnet.");
}
else
{
    Console.WriteLine("Det finns inget förnamn.");
} 


string firstName = "Miriam";
string lastName = null!;

int id;

if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
{
    Console.WriteLine("Något av värdena är inte ifyllda");
}
 */

/*  SWITCH
    ______________________________________
    string key = "gray";

switch (key)
{
    case "blue":
        Console.WriteLine("Unlock blue door");
        break;

    case "orange":
        Console.WriteLine("Unlock orange door");
        break;

    case "gray":
        Console.WriteLine("Unlock gray door");
        break;

    default:    
        Console.WriteLine("Go through white door");
        break;
}
 */

/*  FOR-LOOP
    _____________________________________________________
    Vi loopar igenom en lista eller gör något ett givet antal gånger, vi sätter ett värde


for (initialize value; condition; increment inizialized value)
    {
    }
//i regel ett i, går att sätta vad som helst
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i: {i}");
}

Lite besvärligt, mer omständligt
string[] names = new string[] { "Paula", "Mattias", "Sara", "Simon" };

names[2] = "Miriam";

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

*/

/* FOREACH-LOOP
 * ________________________________________________
    Vi loopar igenom alla objekt i en lista

    forech (var object in list) 
    {        
    }



//kan vara vilken array som helst = givet antal plaster, ex instabox
//int[] numbers = new int[] { 1, 2, 3, 4 };
/*foreach(var name in names)
{
        Console.WriteLine(name);
}

foreach (var name in names)
{
    Console.WriteLine(name);
}
*/

/* WHILE-LOOP
    __________________________________________________________
    gör en sak om och om igen till ett tillstånd är uppnått.
    Varav kontrollen sker i början.

    while(statement)
    {
    }

    int number = 0;
    while (number < 10)
    {
    }
int number = 0;
while (number < 10)
{
    Console.WriteLine(number);
    number++;
}
    i++         gör något sen ökar med 1
    i--         gör något sen minskar med 1
    ++i         öka med 1 och sedan gör något
    --i         minska med 1 och sedan gör något

 */

/* DO- WHILE LOOP
 ______________________________
gör loopen minst en gång sedan kollar den tillståndet

    do
    {
    } while (statement);
 
//Bra med t ex en meny
int number = 0;

do
{
    Console.WriteLine(number);
    number++;   

} while (number < 10);
 
 */



