using System;

namespace Logger;

public record class PersonRecord : IEntity
{
    public PersonRecord(string First, string Last, string? Middle)
    {
        FullName = new(First, Last, Middle);
        Name = FullName.ToString();
    }
    // Implicit Iplementation:
    // Because StudentRecord is an Entity that logically has an Id property.
    public Guid Id { get; init; } = Guid.NewGuid();

    // Implicit Implementation:
    // Because it makes logical sense for the StudentRecord to have easy access to the name property.
    public string Name { get;  set; }

    private FullNameRecord FullName { get; init; }
}