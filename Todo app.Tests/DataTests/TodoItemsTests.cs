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
            Todo result = TodoItems.FindById(todo3.TodoId);
            Assert.Equal(todo3,result);
        }
        [Fact]
        public void ClearTest()
        {
            Todo todo1 = TodoItems.CreateTodo(1, "Engineer");
            Todo todo2 = TodoItems.CreateTodo(2, "Doctor");
            Todo todo3 = TodoItems.CreateTodo(3, "Teacher");
            TodoItems.Clear();
            Assert.Empty(TodoItems.FindAll());
        }
        [Fact]
        public void FindByDoneStatusTest()
        {
            Todo todo1 = TodoItems.CreateTodo(1, "Engineer");
            todo1.Done = true;
            Todo todo2 = TodoItems.CreateTodo(2, "Doctor");
            todo2.Done = true;
            Todo todo3 = TodoItems.CreateTodo(3, "Teacher");
            todo3.Done = false;
            Todo[] result = TodoItems.FindByDoneStatus(false);
            Assert.Contains(todo3, result);
            Assert.DoesNotContain(todo1, result);
        }
        [Fact]
        public void FindByAssigneeByPersonIdInputTest()
        {
            Person per1=new Person("Ekram", "Ahmedin");
            Person per2= new Person("Tim", "Corey");
            Todo todo1 = TodoItems.CreateTodo(1, "Engineer");
            todo1.Assignee = per1; 
            Todo todo2 = TodoItems.CreateTodo(2, "Doctor");
            todo2.Assignee = per2;
            Todo todo3 = TodoItems.CreateTodo(3, "Teacher");
            todo3.Assignee = per1;
            Todo[] result = TodoItems.FindByAssignee(per1.PersonId);
            Assert.Contains(todo1, result);
            Assert.Contains(todo3, result);
            Assert.DoesNotContain(todo2, result);
        }
        [Fact]
        public void FindByAssigneeByAssigneeInputTest()
        {
            Person per1 = new Person("Ekram", "Ahmedin");
            Person per2 = new Person("Tim", "Corey");
            Todo todo1 = TodoItems.CreateTodo(1, "Engineer");
            todo1.Assignee = per1;
            Todo todo2 = TodoItems.CreateTodo(2, "Doctor");
            todo2.Assignee = per2;
            Todo todo3 = TodoItems.CreateTodo(3, "Teacher");
            todo3.Assignee = per1;
            Todo[] result = TodoItems.FindByAssignee(per2);
            Assert.DoesNotContain(todo1, result);
            Assert.DoesNotContain(todo3, result);
            Assert.Contains(todo2, result);
        }
        [Fact]
        public void FindUnassignedTodoItemsTest()
        {
            Person per1 = new Person("Ekram", "Ahmedin");
            Todo todo1 = TodoItems.CreateTodo(1, "Engineer");
            todo1.Assignee = per1;
            Todo todo2 = TodoItems.CreateTodo(2, "Doctor");
            Todo todo3 = TodoItems.CreateTodo(3, "Teacher");
            Todo[] result = TodoItems.FindUnassignedTodoItems();
            Assert.Contains(todo2, result);
            Assert.Contains(todo3, result);
            Assert.DoesNotContain(todo1, result);
            
        }
        [Fact]
        public void RemoveTest()
        {
            Todo todo1 = TodoItems.CreateTodo(1, "Engineer");
            Todo todo2 = TodoItems.CreateTodo(2, "Doctor");
            Todo todo3 = TodoItems.CreateTodo(3, "Teacher");
            Todo todo4 = TodoItems.CreateTodo(4, "Manager");
            TodoItems.Remove(todo3);
            Assert.DoesNotContain(todo3, TodoItems.FindAll());
        }


    }
}
