using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Data
{
    public class TodoSequencer
    {
        private static int todoId=0;
        public static int TodoId
        {
            get { return TodoId;}
        }
        public static int NextTodoId()
        {
            ++todoId;
            return todoId;
        }
        public static void Reset()
        {
            todoId = 0;
        }
    }
}
