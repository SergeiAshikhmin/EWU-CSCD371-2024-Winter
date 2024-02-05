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
    public Guid ID { get; init; } = typeof(EmployeeRecord).GUID;
    public string Name { get; set; }

    public FullNameRecord FullName { get; init; }
}