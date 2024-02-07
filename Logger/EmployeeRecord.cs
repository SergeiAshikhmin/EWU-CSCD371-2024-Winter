using System;

namespace Logger;

// The Employee record inherits the PersonRecord where all of the refactored code was moved.
public record class EmployeeRecord(FullNameRecord FullName) : PersonRecord(FullName);