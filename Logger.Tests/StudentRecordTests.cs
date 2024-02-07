using System;
using Xunit;

namespace Logger.Tests;

public class StudentRecordTests
{
    [Fact]
    public void StudentRecord_GetName_Success()
    {
        FullNameRecord fullName = new("Inigo", "Montoya", "Alex");
        StudentRecord studentRecord = new(fullName);
        Assert.Equal("Inigo Alex Montoya", studentRecord.Name);
    }

    [Fact]
    public void StudentRecord_SameStudentEquals_Success()
    {
        FullNameRecord fullName = new("Inigo", "Montoya", "Alex");
        StudentRecord student1 = new(fullName);
        StudentRecord student2 = student1 with {};
        Assert.True(student1.Equals(student2));
    }

    [Fact]
    public void StudentRecord_TwoStudentsNotEqual_Success()
    {
        FullNameRecord fullName = new("Inigo", "Montoya", "Alex");
        StudentRecord student1 = new(fullName);
        StudentRecord student2 = new(fullName);
        Assert.False(student1.Equals(student2));
    }

    [Fact]
    public void StudentRecord_SetFirstLastWithString_Success()
    {
        StudentRecord studentRecord = new("Inigo", "Montoya");
        Assert.Equal("Inigo Montoya", studentRecord.Name);
    }

    [Fact]
    public void StudentRecord_SetFirstLastMiddleWithString_Success()
    {
        StudentRecord record = new("Inigo", "Montoya", "Alex");
        Assert.Equal("Inigo Alex Montoya", record.Name);
    }
}