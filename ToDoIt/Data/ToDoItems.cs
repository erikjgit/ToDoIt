using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt.Model;

namespace ToDoIt.Data
{
    public class ToDoItems
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

        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            int i=0;
            Todo[] result = new Todo[toDoItems.Length];
            foreach(Todo t in toDoItems)
            {
                if (t.GetDoneStatus() == doneStatus)
                {
                    result[i++] = t;
                }
            }
            Array.Resize(ref toDoItems, i);
            return result;
        }

        public Todo[] FindByAssignee(int personId)
        {
            int i=0;
            Todo[] result = new Todo[toDoItems.Length];
            foreach (Todo t in toDoItems)
            {
                if (t.GetAssignee().GetId() == personId)
                {
                    result[i++] = t;
                }
            }
            Array.Resize(ref toDoItems, i);
            return result;
        }

        public Todo[] FindByAssignee(Person p)
        {
            int i=0;
            Todo[] result = new Todo[toDoItems.Length];
            foreach (Todo t in toDoItems)
            {
                if (Equals(t.GetAssignee() , p))
                {
                    result[i++] = t;
                }
            }
            Array.Resize(ref toDoItems, i);
            return result;
        }

        public Todo[] FindByUnAssignedToDoItems()
        {
            int i=0;
            Todo[] result = new Todo[toDoItems.Length];
            foreach (Todo t in toDoItems)
            {
                if (t.GetAssignee() == null)
                {
                    result[i++] = t;
                }
            }
            Array.Resize(ref toDoItems, i);
            return result;
        }

        public void RemoveTodo(int toDoId)
        {
            foreach (Todo t in toDoItems)
            {
                if (toDoId==t.GetId())
                {
                    Todo[] newTodo = new Todo[(toDoItems.Length - 1)];
                    int j = 0;
                    for (int i = 0; i < toDoItems.Length; i++)
                    {
                        if (!(Equals(t, toDoItems[i])))
                        {
                            newTodo[j++] = toDoItems[i];
                        }
                    }
                    toDoItems = newTodo;
                }
            }
        }
    }
}
