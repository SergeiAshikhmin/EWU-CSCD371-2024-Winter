using System;
using Xunit;

namespace Logger.Tests;

public class EmployeeRecordTests
{
    [Fact]
    public void EmployeeRecord_InitializeObject_Success()
    {
        EmployeeRecord employeeRecord = new("Inigo", "Montoya", "Alex");
        Assert.Equal("Inigo Alex Montoya", employeeRecord.Name);
    }

    [Fact]
    public void EmployeeRecord_SameEmployee_Success()
    {
        EmployeeRecord employee1 = new("Inigo", "Montoya", "Alex");
        EmployeeRecord employee2 = employee1 with {};
        Assert.True(employee1.Equals(employee2));
    }

    [Fact]
    public void EmployeeRecord_TwoEmployeesNotEqual_Success()
    {
        EmployeeRecord employee1 = new("Inigo", "Montoya", "Alex");
        EmployeeRecord employee2 = new("Inigo", "Montoya", "Alex");
        Assert.False(employee1.Equals(employee2));
    }
}