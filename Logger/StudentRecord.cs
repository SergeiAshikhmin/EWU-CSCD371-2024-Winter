using System;
using System.Reflection.Metadata.Ecma335;

namespace Logger;

// A StudentRecord class inherits from the PersonRecord base class and passes a constructor call to it.
// For this class implementation, see PersonRercord
public record class StudentRecord(string First, string Last, string? Middle) : PersonRecord(First, Last, Middle);