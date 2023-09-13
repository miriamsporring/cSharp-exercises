namespace _02_Classes_Classes_GettersAndSetters.Models;

 internal class Customer
{
	private string firstName;

	public string FirstName 
	{
		get { return firstName; } 
		set {firstName = value.Trim(); }	
	}

	public string LastName { get; set; }

public string FullName => $"{FirstName} {LastName}";
}
















/* 
 internal class Customer
{
	private string firstName;

	public string FirstName
	{
		get { return firstName; }
		set { firstName = value; }
	}

	public string LastName; { get; set; }

    public string FullName =>$"{FirstName} {LastName}";
}
 */







/*internal class Customer //en klass kan bara vara internal eller public
{
	public string firstName;

	public string FirstName
	{
		get { return firstName; }// get 0> firstName; }
		set { firstName = value.Trim(); }
	}

	public string LastName { get; set; } //samma som ovan, förenklat

    public string FullName => $"{FirstName} {LastName}";
}*/



