using System;
using System.Reflection.Metadata.Ecma335;

namespace Logger;

public record class StudentRecord(string First, string Last, string? Middle) : PersonRecord(First, Last, Middle);