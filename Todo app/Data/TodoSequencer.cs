using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Data
{
    public class TodoSequencer
    {
        private static int todoId;
        public static int TodoId
        {
            get { return todoId; }
            set { todoId = value; }
        }
        public static int NextTodoId()
        {
            return ++todoId;
        }
        public static void Reset()
        {
            todoId = 0;
        }
    }
}
