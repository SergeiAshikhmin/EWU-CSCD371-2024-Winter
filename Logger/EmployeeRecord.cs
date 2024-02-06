using System;

namespace Logger;

// The Emplyee record inperits the PresonRecord where all of the refactored code was moved.
public record class EmployeeRecord(FullNameRecord FullName) : PersonRecord(FullName);