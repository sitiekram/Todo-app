using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Data
{
    public class TodoSequencer
    {
        private static int todoId;
        public static int nextTodoId()
        {
            todoId++;
            return todoId;
        }
        public static void reset()
        {
            todoId = 0;
        }
    }
}
