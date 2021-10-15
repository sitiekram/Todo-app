using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo_app.Model;

namespace Todo_app.Data
{
    public class TodoItems
    {
        private static Todo[] todoArray = new Todo[0];
        public static int Size()
        {
            return todoArray.Length;
        }
        public static Todo[] FindAll()
        {
            return todoArray;
        }

        public static Todo FindById(int todoId)
        {
            Todo result = null;
            foreach (Todo i in todoArray)
            {
                if (i.TodoId == todoId)
                {
                    result = i;
                }
            }

            return result;
        }
        public static Todo CreateTodo(int todoId, string description)
        { 
            Todo sut = new Todo(todoId,description);
            Todo[] tempTodoArray = new Todo[Size() + 1];
            for (int i = 0; i < Size(); i++)
            {
                tempTodoArray[i] = todoArray[i];
            }
            tempTodoArray[Size()] = sut;
            todoArray = tempTodoArray;
            return sut;
        }
        public static void Clear()
        {
            Todo[] temTodoArray = new Todo[0];
            todoArray = temTodoArray;
        }
        public static Todo[] FindByDoneStatus(bool doneStatus)
        {
            IEnumerable<Todo> result = todoArray.Where(x => x.Done == doneStatus);
            Todo[] resultTodoArray = result.ToArray();
            return resultTodoArray;
        }
        public static Todo[] FindByAssignee(int personId)
        {
            IEnumerable<Todo> result = todoArray.Where(x => x.Assignee.PersonId == personId);
            Todo[] resultTodoArray = result.ToArray();
            return resultTodoArray;
        }
        public static Todo[] FindByAssignee(Person assignee)
        {
            IEnumerable<Todo> result = todoArray.Where(x => x.Assignee == assignee);
            Todo[] resultTodoArray = result.ToArray();
            return resultTodoArray;
        }
        public static Todo[] FindUnassignedTodoItems()
        {
            IEnumerable<Todo> result= todoArray.Where(x => x.Assignee == null);
            Todo[] resultTodoArray = result.ToArray(); 
            return resultTodoArray;
        }
        public static void Remove(Todo todoRemove)
        {
            int index=Size();
            int j = 0;
            for (int i = 0; i < Size(); i++)
            {
                if(todoArray[i]==todoRemove)
                {
                    index = i;
                    break;
                }
            }
            if (index != Size())
            {
                Todo[] tempTodoArray = new Todo[Size() - 1];
                for (int i = 0; i < Size(); i++)
                {
                    if (i != index)
                    {
                        tempTodoArray[j] = todoArray[i];
                        j++;
                    }
                }
                todoArray = tempTodoArray;
            }
            
        }
    }
}
