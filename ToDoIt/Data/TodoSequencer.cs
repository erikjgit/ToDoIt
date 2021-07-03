using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Data
{
    public class TodoSequencer
    {
        private static int toDoId;

        public static int IncrementId()
        {
            return ++toDoId;

        }

        public static void Reset()
        {
            personId = 0;
        }
    }
}
