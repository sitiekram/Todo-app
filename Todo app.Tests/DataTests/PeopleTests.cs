using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Data;
using Todo_app.Model;
using Xunit;

namespace Todo_app.Tests.DataTests
{
    public class PeopleTests
    {
        [Fact]
        public void CreatePersonTest()
        {
            string firstName = "Ekram";
            string lastName = "Ahmedin";
            Person per1 = null;
            per1=People.CreatePerson(firstName, lastName);
            Assert.NotNull(per1);
            Assert.Equal("Ekram",per1.FirstName);
            Assert.Equal("Ahmedin",per1.LastName);
        }
        [Fact]
        public void ClearTest()
        {
            Person per1 = People.CreatePerson("Ekram", "Ahmedin");
            Person per2 = People.CreatePerson("Tim", "Corey");
            Person per3 = People.CreatePerson("Daniel", "Ulf");
            People.Clear();
            Assert.Empty(People.FindAll());
        }

        [Fact]
        public void FindByIdTest()
        {
            Person per1 = People.CreatePerson("Ekram", "Ahmedin");
            Person per2 = People.CreatePerson("Tim", "Corey");
            Person per3 = People.CreatePerson("Daniel", "Ulf");
            Person result = People.FindById(per2.PersonId);
            Assert.Equal(per2,result);
        }
        [Fact]
        public void RemoveTest()
        {
            Person per1 = People.CreatePerson("Ekram", "Ahmedin");
            Person per2 = People.CreatePerson("Tim", "Corey");
            Person per3 = People.CreatePerson("Daniel", "Ulf");
            Person per4 = People.CreatePerson("Marwan", "Seid");
            People.Remove(per2);
            Assert.DoesNotContain(per2, People.FindAll());
        }

    }
    
}
