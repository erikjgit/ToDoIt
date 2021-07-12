using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt.Model;

namespace ToDoIt.Data
{
    public class People
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

        public Person AddPerson(string firstName, string lastName)
        {
            Array.Resize(ref people, (people.Length+1));
            Person newPerson = new Person(PersonSequencer.IncrementId(), firstName, lastName);
            people[(people.Length - 1)] = newPerson;
            return newPerson;
        }

        public void Clear()
        {
            people = new Person[0];
            PersonSequencer.Reset();
        }

        public void RemovePerson(int personId)
        {
            foreach (Person p in people)
            {
                if (personId == p.GetId())
                {
                    Person[] newPeople = new Person[(people.Length - 1)];
                    int j = 0;
                    for (int i = 0; i < people.Length; i++)
                    {
                        if (!(Equals(p, people[i])))
                        {
                            newPeople[j++] = people[i];
                        }
                    }
                    people = newPeople;
                }
            }
        }
    }
}
