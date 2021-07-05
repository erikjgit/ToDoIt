using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Model
{
    public class Todo
    {
        private readonly int todoId;
        private string description;
        private bool done;
        private Person assignee;

        public Todo(int todoId, string description)
        {
            this.todoId = todoId;
            this.description = description;
            done = false;
        }

        public int GetId()
        {
            return (todoId);
        }

        public bool GetDoneStatus()
        {
            return (done);
        }

        public Person GetAssignee()
        {
            return assignee;
        }

        //public void SetAssignee()
    }
}
