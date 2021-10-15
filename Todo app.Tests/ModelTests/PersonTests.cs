using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Model;
using Xunit;

namespace Todo_app.Tests.ModelTests
{
    public class PersonTests
    {
        [Fact]
        public void Constructor()
        {
            Person sut = null;
            sut = new Person();
            Assert.NotNull(sut);
            Assert.Equal("Ekram", sut.FirstName);
            Assert.Equal("Ahmedin", sut.LastName);
        }

        [Fact]
        public void ConstructorWithParameterInput()
        {
            string firstName = "Tim";
            string lastName = "Andersson";
            Person sut = null;
            sut=new Person(firstName, lastName);
            Assert.NotNull(sut);
            Assert.Equal("Tim",sut.FirstName);
            Assert.Equal("Andersson", sut.LastName);
        }

        [Theory]
        [InlineData("", "Andersson")]
        [InlineData(null, "Andersson")]
        public void CheckFirstName(string firstName,string lastName)
        {
            ArgumentException result= Assert.Throws<ArgumentException>(() => new Person(firstName, lastName));
            Assert.Equal("First name should be valid name", result.Message);
        }

        [Theory]
        [InlineData("Tim","")]
        [InlineData("Tim",null)]
        public void CheckLastName(string firstName, string lastName)
        {
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Person(firstName, lastName));
            Assert.Equal("Last name should be valid name", result.Message);
        }
        
    }
}
