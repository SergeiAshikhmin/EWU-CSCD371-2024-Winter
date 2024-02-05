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

    [Fact]
    public void FullName_SetRecordToNull_Suceess()
    {
        Assert.Throws<ArgumentNullException>(
            () => new FullNameRecord(null!, null!, null) );
    }

    [Fact]
    public void FullName_OptionalMiddle_Sucess()
    {
        FullNameRecord fullName = new("Inigo", "Montoya", null);
        Assert.Equal("FullNameRecord { First = Inigo, Last = Montoya, Middle =  }", fullName.ToString());
    }
}