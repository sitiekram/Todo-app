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

        [Fact]
        public void CheckFirstNameIsNotEmpty()
        {
            string firstName ="";
            string lastName = "Andersson";
            ArgumentException result= Assert.Throws<ArgumentException>(() => new Person(firstName, lastName));
            Assert.Equal("First name should be valid name", result.Message);
        }
        [Fact]
        public void CheckFirstNameIsNotNull()
        {
            string firstName = null;
            string lastName = "Andersson";
            Assert.Throws<NullReferenceException>(() => new Person(firstName, lastName));
        }

        [Fact]
        public void CheckLastNameIsNotEmpty()
        {
            string firstName = "Tim";
            string lastName = "";
            ArgumentException result = Assert.Throws<ArgumentException>(() => new Person(firstName, lastName));
            Assert.Equal("Last name should be valid name", result.Message);
        }
        [Fact]
        public void CheckLastNameIsNotNull()
        {
            string firstName = "Tim";
            string lastName = null;
            Assert.Throws<NullReferenceException>(() => new Person(firstName, lastName));
        }
    }
}
