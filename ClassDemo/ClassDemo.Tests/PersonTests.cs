using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Tests;

public class PersonTests
{
    [Fact]
    public void Constructor_ValidName_SuccessfulInitialization()
    {
        Person person = new();
        
    }

    [Fact]
    public void FirstName_SetInigo_Success()
    {
        Person person = new();
        person.FirstName = "Inigo";
        Assert.Equal("Inigo", person.FirstName);

    }

    [Fact]
    public void FirstName_SetFirstNameNull_Success()
    {
        Person person = new(null!);
        Assert.Throws<ArgumentNullException>(
            () => person.FirstName = null!);
    }

    [Fact]
    public void FirstName_SetNull_Success()
    {
        Person? person;
        Assert.Throws<ArgumentException>(
            () =>
            {
                person = new(null!);
            });
    }

    [Fact]
    public void MiddleName_SetInigo_Success()
    {
        Person person = new("Inigo")
        {
            MiddleName = "Middle"
        };

        Assert.Equal("Middle", person.MiddleName);
    }

}
