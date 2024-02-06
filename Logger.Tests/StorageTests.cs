using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Logger.Tests;
public class StorageTests
{
    // Book
    [Fact]
    public void Add_BookRecord_Success()
    {
        BookRecord record = new("The Great Gatsby");
        

        Storage storage = new();
        storage.Add(record);

        Assert.True(storage.Contains(record));
    }

    [Fact]
    public void Remove_BooktRecord_Success()
    {
        BookRecord record = new("To Kill a Mockingbird");

        Storage storage = new();
        storage.Add(record);

        storage.Remove(record);

        Assert.False(storage.Contains(record));
    }

    [Fact]
    public void Get_ReturnsCorrectBookRecordId_Success()
    {
        BookRecord record = new("Moby-Dick");

        Storage storage = new();
        storage.Add(record);

        Assert.Equal<IEntity>(record, storage.Get(record.Id));
    }

    // Student

    // Employee
    [Fact]
    public void Add_EmployeRecord_Success()
    {
        FullNameRecord fullName = new("Inigo", "Montoya", "Alex");
        EmployeeRecord employeeRecord = new(fullName);
        Storage storage = new();
        storage.Add(employeeRecord);
        Assert.True(storage.Contains(employeeRecord));
    }

    [Fact]
    public void Remove_EmployeRecord_Success()
    {
        FullNameRecord fullName = new("Inigo", "Montoya", "Alex");
        EmployeeRecord employeeRecord = new(fullName);
        Storage storage = new();
        storage.Add(employeeRecord);
        storage.Remove(employeeRecord);
        Assert.False(storage.Contains(employeeRecord));
    }

    [Fact]
    public void Contains_EmployeeRecord_Success()
    {
        FullNameRecord fullName = new("Inigo", "Montoya", "Alex");
        EmployeeRecord employeeRecord = new(fullName);
        EmployeeRecord employeeRecord1 = new(fullName);
        Storage storage = new();
        storage.Add(employeeRecord);
        storage.Add(employeeRecord1);
        Assert.True(storage.Contains(employeeRecord));
    }

    [Fact]
    public void Get_EmployeeRecord_Success()
    {
        FullNameRecord fullName = new("Inigo", "Montoya", "Alex");
        EmployeeRecord employeeRecord = new(fullName);
        EmployeeRecord employeeRecord1 = new(fullName);
        Storage storage = new();
        storage.Add(employeeRecord);
        storage.Add(employeeRecord1);
        Assert.Equal(employeeRecord, storage.Get(employeeRecord.Id));
    }
}
