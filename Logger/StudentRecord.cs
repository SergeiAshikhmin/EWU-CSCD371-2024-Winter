using System;
using System.Reflection.Metadata.Ecma335;

namespace Logger;

public record class StudentRecord : IEntity
{
    public StudentRecord(string First, string Last, string? Middle = null)
    {
        FullName = new(First, Last, Middle);

        if(FullName.Middle == null){
            Name = FullName.First + " " + FullName.Last;
        }
        else{
            Name = FullName.First + " " + FullName.Middle + " " +  FullName.Last;
        }
    }

    // We choose an implicit implementation for the Id property because StudentRecord is an Entity that logically has an Id property.
    public Guid Id { get; init; } = Guid.NewGuid();

    // We choose an implicit implementation for the Name property because it makes logical sense for the StudentRecord to have
    // easy access to the name property.
    public string Name { get; set; }
    private FullNameRecord FullName {get; init;}

}