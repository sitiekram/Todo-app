using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Model;
namespace Todo_app.Data
{
    public class People
    {
        private static Person[] personArray =new Person[0];
        public static Person[] PersonArray
        {
            get;set;
        }
        public static int Size()
        {
            return personArray.Length;
        }
        public static Person[] FindAll()    
        {
            return personArray;
        }

        public static Person FindById(int personId)
        {
            Person result = null;
            foreach(Person i in personArray)
            {
                if(i.PersonId==personId)
                {
                    result = i;
                }
            }

            return result;
        }
        public static Person CreatePerson(string firstName,string lastName)
        {
            Person sut = new Person(firstName, lastName);
            //sut.PersonId = PersonSequencer.nextPersonId();
            Person[] tempPersonArray = new Person[Size() + 1];
            for (int i = 0; i < Size();i ++)
            {
                tempPersonArray[i] = personArray[i];
            }
            tempPersonArray[Size()] = sut;
            personArray = tempPersonArray;
            return sut;
        }
        public static void Clear()
        {
            //for (int i = 0; i < Size(); i++)
            //{
            //    PersonArray[i] = null;
            //}
            Person[] temPersonArray = new Person[0];
            PersonArray = temPersonArray;
        }
    }
}
