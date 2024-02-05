using System;

namespace Logger;

public record class StudentRecord : IEntity
{
    public Guid Id { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}