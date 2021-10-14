using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Data;
using Todo_app.Model;
using Xunit;

namespace Todo_app.Tests.DataTests
{
    public class TodoItemsTests
    {
        [Fact]
        public void CreateTodoTest()
        {
            int todoId = 1;
            string description = "Engineer";
            Todo todo1 = null;
            todo1 = TodoItems.CreateTodo(todoId,description);
            Assert.NotNull(todo1);
            Assert.Equal(1, todo1.TodoId);
            Assert.Equal("Engineer", todo1.Description);
        }
        [Fact]
        public void FindByIdTest()
        {
            Todo todo1 = TodoItems.CreateTodo(1, "Engineer");
            Todo todo2 = TodoItems.CreateTodo(2, "Doctor");
            Todo todo3 = TodoItems.CreateTodo(3, "Teacher");
            Assert.Equal(todo3, TodoItems.FindById(3));
        }
        [Fact]
        public void ClearTest()
        {
            Todo todo1 = TodoItems.CreateTodo(1, "Engineer");
            Todo todo2 = TodoItems.CreateTodo(2, "Doctor");
            Todo todo3 = TodoItems.CreateTodo(3, "Teacher");
            TodoItems.Clear();
            Assert.Empty(TodoItems.TodoArray);
        }
        [Fact]
        public void FindByDoneStatusTest()
        {
            Todo todo1 = TodoItems.CreateTodo(1, "Engineer");
            TodoItems.TodoArray[0].Done = true;
            Todo todo2 = TodoItems.CreateTodo(2, "Doctor");
            TodoItems.TodoArray[1].Done = true;
            Todo todo3 = TodoItems.CreateTodo(3, "Teacher");
            TodoItems.TodoArray[2].Done = false;
            Todo[] result = TodoItems.FindByDoneStatus(false);
            Assert.Contains(todo3, result);
        }

    }
}
