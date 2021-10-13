using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Data;
namespace Todo_app.Model
{
    public class Person
    {
       private readonly int personId;
       private string firstName;
       private string lastName;

       public int PersonId 
        {
            get { return personId; }
        }
       public string FirstName
        {
            get { return firstName; }
            set
            {
               if(value.Equals(""))
                {
                    throw new ArgumentException("First name should be valid name");
                }
                else if (value.Equals(null))
                {
                    throw new NullReferenceException("First name can't be null");
                }
                else
                {
                    firstName=value;
                }
            }
        }
       public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Equals(""))
                {
                    throw new ArgumentException("Last name should be valid name");
                }
                else if(value.Equals(null))
                {
                    throw new NullReferenceException("Last name can't be null");
                }
                else
                {
                    lastName=value;
                }
            }
        }
       public Person()
        {
            FirstName = "Ekram";
            LastName = "Ahmedin";
        }
        public Person(string firstName,string lastName)
        {
            personId = PersonSequencer.NextPersonId();
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
