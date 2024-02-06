using System;

namespace Logger;

public record class EmployeeRecord : PersonRecord
{
    public EmployeeRecord(string First, string Last, string? Middle) : base(First, Last, Middle){}
}