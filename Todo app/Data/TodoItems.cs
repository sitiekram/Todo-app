using System;
using System.Collections.Generic;
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
            //Array.Clear(people, null, Size());
        }
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            Todo[] resultTodoArray = new Todo[0];
            int j = 0;
            for (int i = 0; i < Size(); i++)
            {
                if(todoArray[i].Done==doneStatus)
                {
                    resultTodoArray[j] = todoArray[i];
                    j++;
                }
            }
            return resultTodoArray;
        }
        public Todo[] FindByAssignee(int personId)
        {
            Todo[] resultTodoArray = new Todo[0];
            int j = 0;
            for (int i = 0; i < Size(); i++)
            {
                if (todoArray[i].Assignee.PersonId == personId)
                {
                    resultTodoArray[j] = todoArray[i];
                    j++;
                }
            }
            return resultTodoArray;
        }
        public Todo[] FindByAssignee(Person assignee)
        {
            Todo[] resultTodoArray = new Todo[0];
            int j = 0;
            for (int i = 0; i < Size(); i++)
            {
                if (todoArray[i].Assignee== assignee)
                {
                    resultTodoArray[j] = todoArray[i];
                    j++;
                }
            }
            return resultTodoArray;
        }
        public Todo[] FindUnassignedTodoItems()
        {
            Todo[] resultTodoArray = new Todo[0];
            int j = 0;
            for (int i = 0; i < Size(); i++)
            {
                if (todoArray[i].Assignee == null)
                {
                    resultTodoArray[j] = todoArray[i];
                    j++;
                }
            }
            return resultTodoArray;
        }
    }
}
