using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Model
{
    public class Person
    {
        private readonly int personId;
//        public int PersonId { get; set; }
        private string firstName, lastName;

        public Person(int personId, string firstName, string lastName)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int GetId()
        {
            return (personId);
        }
    }
}
