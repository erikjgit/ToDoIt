using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt.Model;

namespace ToDoIt.Data
{
    class ToDoItems
    {
        Todo[] toDoItems = new Todo[0];

        public int Size()
        {
            return (toDoItems.Length);
        }

        public Todo[] FindAll()
        {
            return(toDoItems);
        }

        public Todo FindById(int todoId)
        {
            foreach (Todo t in toDoItems)
            {
                if (t.GetId() == todoId)
                {
                    return (t);
                }
            }

            return (null);
        }

        public void AddToDoItem(string description)
        {
            Array.Resize(ref toDoItems, (toDoItems.Length+1));
            toDoItems[(toDoItems.Length - 1)] = new Todo(TodoSequencer.IncrementId(), description);
        }

        public void Clear()
        {
            toDoItems = new Todo[0];
        }

    }
}
