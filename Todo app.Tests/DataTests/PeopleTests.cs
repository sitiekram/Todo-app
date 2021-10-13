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
        //[Fact]
        //public void SizeTest()
        //{
        //    People.PersonArray = new Person[3];
        //    People.PersonArray[0] = new Person("Ekram", "Seid");
        //    People.PersonArray[1] = new Person("Tim", "Corey");
        //    People.PersonArray[2] = new Person("Marwan", "Ahmedin");


        //    //People.PersonArray ={new Person("Ekram","Seid"),new Person("Tim","Corey"),new Person("Marwan","Ahmedin")};
        //    Assert.Equal(3, People.Size());
        //}

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
        public void FindByIdTest()
        {
            Person per1 = People.CreatePerson("Ekram", "Ahmedin");
            Person per2 = People.CreatePerson("Tim", "Corey");
            Person per3 = People.CreatePerson("Daniel", "Ulf");
            Assert.Equal(per2, People.FindById(2));
        }

        [Fact]
        public void ClearTest()
        {
            Person per1 = People.CreatePerson("Ekram", "Ahmedin");
            Person per2 = People.CreatePerson("Tim", "Corey");
            Person per3 = People.CreatePerson("Daniel", "Ulf");
            People.Clear();
            Assert.Empty(People.PersonArray);
        }

    }
    
}
