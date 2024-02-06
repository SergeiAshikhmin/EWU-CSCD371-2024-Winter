using System;

namespace Logger;

// The Emplyee record inperits the PresonRecord where all of the refactored code was moved.
public record class EmployeeRecord(string First, string Last, string? Middle) : PersonRecord(First, Last, Middle);