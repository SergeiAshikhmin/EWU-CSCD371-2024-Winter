using System;

namespace Logger;
//Why its a Value Type:
// The reason we decided to use a value type is because it logically represents a single value and is immutable.
// Another reason this is a value type is because this record does not need to be inherited.
//Why its Immutable:
// The reason this struct is immutable is because it is a value type and value types must be immutable. 
// Here the readonly modifyer ensures that the record is immutable.
public readonly record struct FullNameRecord(string First, string Last, string? Middle = null)
{
    public string First
    {
        get => First;
        init => First = value ?? throw new ArgumentNullException(nameof(value));
    }
}