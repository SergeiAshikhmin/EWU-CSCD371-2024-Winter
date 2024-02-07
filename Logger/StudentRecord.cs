using System;
using System.Reflection.Metadata.Ecma335;

namespace Logger;

// A StudentRecord class inherits from the PersonRecord base class and passes a constructor call to it.
// For this class implementation, see PersonRecord
public record class StudentRecord(FullNameRecord FullName) : PersonRecord(FullName)
{
    public StudentRecord(string First, string Last, string Middle) : this(new FullNameRecord(First, Last, Middle)) { }

    public StudentRecord(string First, string Last) : this(new FullNameRecord(First, Last)) { }
}