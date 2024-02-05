using System;
using Xunit;

namespace Logger.Tests;

public class EmployeeRecordTests
{
    [Fact]
    public void EmployeeRecord_InitializeObject_Success()
    {
        EmployeeRecord employeeRecord = new("Sergei", "Ashikhmin", "D");
        Assert.Equal("Sergei D Ashikhmin", employeeRecord.Name);
    }
}