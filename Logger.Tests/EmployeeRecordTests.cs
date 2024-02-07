using System;
using Xunit;

namespace Logger.Tests;

public class EmployeeRecordTests
{
    [Fact]
    public void EmployeeRecord_InitializeObjectFullNameParam_Success()
    {
        FullNameRecord fullName = new("Inigo", "Montoya", "Alex");
        EmployeeRecord employeeRecord = new(fullName);
        Assert.Equal("Inigo Alex Montoya", employeeRecord.Name);
    }

    [Fact]
    public void EmployeeRecord_InitializeObjectThreeStringParam_Success()
    {
        EmployeeRecord employeeRecord = new("Inigo", "Montoya", "Alex");
        Assert.Equal("Inigo Alex Montoya", employeeRecord.Name);
    }
        
    [Fact]
    public void EmployeeRecord_InitializeObjectTwoStringParam_Success()
    {
        EmployeeRecord employeeRecord = new("Inigo", "Montoya");
        Assert.Equal("Inigo Montoya", employeeRecord.Name);
    }

    [Fact]
    public void EmployeeRecord_SameEmployee_Success()
    {
        FullNameRecord fullName = new("Inigo", "Montoya", "Alex");
        EmployeeRecord employee1 = new(fullName);
        EmployeeRecord employee2 = employee1 with {};
        Assert.True(employee1.Equals(employee2));
    }

    [Fact]
    public void EmployeeRecord_TwoEmployeesNotEqual_Success()
    {
        FullNameRecord fullName = new("Inigo", "Montoya", "Alex");
        EmployeeRecord employee1 = new(fullName);
        EmployeeRecord employee2 = new(fullName);
        Assert.False(employee1.Equals(employee2));
    }
}