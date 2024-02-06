using System;
using Xunit;

namespace Logger.Tests;

public class StudentRecordTests
{
    [Fact]
    public void StudentRecord_getName_Success()
    {
        StudentRecord studentRecord = new("Inigo", "Montoya", "Alex");
        Assert.Equal("Inigo Alex Montoya", studentRecord.Name);
    }

    [Fact]
    public void StudentRecord_SameStudentEquals_Success()
    {
        StudentRecord student1 = new("Inigo", "Montoya", "Alex");
        StudentRecord student2 = student1 with {};
        Assert.True(student1.Equals(student2));
    }

    [Fact]
    public void StudentRecord_TwoStudentsNotEqual_Success()
    {
        StudentRecord student1 = new("Inigo", "Montoya", "Alex");
        StudentRecord student2 = new("Inigo", "Montoya", "Alex");
        Assert.False(student1.Equals(student2));
    }

    [Fact]
    public void StudentRecord_ChangeName_Success()
    {
        string First = "Inigo";
        string Last = "Montoya";
        StudentRecord record = new(First, Last, null);

        FullNameRecord fullNameRecord = new("Harry", "Potter", null);
        record.Name = "Sergei";
    }
}