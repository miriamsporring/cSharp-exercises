using System.ComponentModel.DataAnnotations;

namespace _03_Classes_Constructions.Models;

internal class Contact
{

    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!; //värdet kan inte vara tomt, ! ignorera felmeddelanden
    public string? PhoneNumber { get; set; }  //? gör parametern nullable, tillåts vara tom
}

