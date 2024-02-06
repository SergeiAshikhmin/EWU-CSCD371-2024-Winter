using System;

namespace Logger;

public record class EmployeeRecord : IEntity
{
    public EmployeeRecord(string First, string Last, string? Middle)
    {
        FullName = new(First, Last, Middle);
        
        if(String.IsNullOrEmpty(Middle))
        {
            Name = First + " " + Last;
        }
        else
        {
            Name = First + " " + Middle + " " + Last;
        }
    }
    // Implicit Iplementation:
    // Because StudentRecord is an Entity that logically has an Id property.
    public Guid Id { get; init; } = typeof(EmployeeRecord).GUID;

    // Implicit Implementation:
    // Because it makes logical sense for the StudentRecord to have easy access to the name property.
    public string Name { get; set; }

    public FullNameRecord FullName { get; init; }
}