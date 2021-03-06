using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Model;
namespace Todo_app.Data
{
    public class People
    {
        private static Person[] personArray =new Person[0];
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
            Person[] temPersonArray = new Person[0];
            personArray = temPersonArray;
        }
        public static void Remove(Person perRemove)
        {
            int index = Size();
            int j = 0;
            for (int i = 0; i < Size(); i++)
            {
                if (personArray[i] == perRemove)
                {
                    index = i;
                    break;
                }
            }
            if(index != Size())
            {   
                Person[] tempPersonArray = new Person[Size() - 1];
                for (int i = 0; i < Size(); i++)
                {
                    if (i != index)
                    {
                        tempPersonArray[j] = personArray[i];
                        j++;
                    }
                }
                personArray = tempPersonArray;
            }
        }
    }
}
