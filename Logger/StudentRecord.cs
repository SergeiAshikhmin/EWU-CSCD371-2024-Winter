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
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Name { get; set; }
    public FullNameRecord FullName {get; init;}

}