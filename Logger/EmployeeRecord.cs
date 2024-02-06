using System;

namespace Logger;

public record class EmployeeRecord(string First, string Last, string? Middle) : PersonRecord(First, Last, Middle);