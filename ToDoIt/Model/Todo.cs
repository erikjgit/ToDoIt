using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Model
{
    public class Todo
    {
        private readonly int todoId;
        private string description, assignee;
        private bool done;

        public Todo(int todoId, string description)
        {
            this.todoId = todoId;
            this.description = description;
            done = false;
        }
    }
}
