using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.ExceptionServices;

namespace Logger;

public record class PersonRecord(FullNameRecord FullName) : IEntity
{
    // Implicit Iplementation:
    // Because StudentRecord is an Entity that logically has an Id property.
    public Guid Id { get; init; } = Guid.NewGuid();

    // Implicit Implementation:
    // Because it makes logical sense for the StudentRecord to have easy access to the name property.
    public string Name { get; set; } = FullName.GetName();

}