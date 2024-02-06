using System;
using System.Reflection.Metadata.Ecma335;

namespace Logger;

public record class StudentRecord : PersonRecord
{
    public StudentRecord(string First, string Last, string? Middle) : base(First, Last, Middle){}
}