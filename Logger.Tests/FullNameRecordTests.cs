using System;
using Xunit;

namespace Logger.Tests;

public class FullNameRecordTests
{
    [Fact]
    public void FullName_RecordInitialized_Success()
    {
        FullNameRecord fullName = new("Inigo", "Montoya", "Alex");
        Assert.Equal("FullNameRecord { First = Inigo, Last = Montoya, Middle = Alex }", fullName.ToString());
    }
}