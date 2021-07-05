using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt.Model;

namespace ToDoIt.Data
{
    class People
    {
        Person[] people = new Person[0];

        public int Size()
        {
            return (people.Length);
        }

        public Person[] FindAll()
        {
            return people;
        }

        public Person FindById(int personId)
        {
            foreach(Person p in people)
            {
                if (p.GetId() == personId)
                {
                    return (p);
                }
            }

            return (null);
        }

        public void AddPerson(string firstName, string lastName)
        {
            Array.Resize(ref people, (people.Length));
            people[(people.Length - 1)] = new Person(PersonSequencer.IncrementId(), firstName, lastName);
        }

        public void Clear()
        {
            people = new Person[0];
        }

    }
}
