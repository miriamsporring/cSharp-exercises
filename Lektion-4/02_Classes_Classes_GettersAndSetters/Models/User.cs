namespace _02_Classes_Classes_GettersAndSetters;

internal class User
{
    private string email;

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get => email; set => email = value.Trim().ToLower(); }   
    public string Password { get; set; }
}
