
namespace ClassDemo;

public class Person
{
    private string? _firstName;

    public Person(string firstName)
    {
        FirstName = firstName;
    }

    public string FirstName 
    { 
        get => _firstName!; 
        set
        {
            _firstName = value ?? throw new ArgumentNullException(nameof(value));
        } 
    }

    public string? MiddleName { get; set; }
}