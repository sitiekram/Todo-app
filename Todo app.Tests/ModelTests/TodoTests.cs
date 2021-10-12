using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Model;
using Xunit;

namespace Todo_app.Tests.ModelTests
{
    public class TodoTests
    {
        [Theory]
        [InlineData(13,"This is a todo list application")]
        [InlineData(11,"")]
        public void Constructor(int todoId,string description)
        {
            Todo list = null;
            list=new Todo(todoId,description);
            Assert.NotNull(list);
            Assert.Equal(todoId,list.TodoId);
            Assert.Equal(description,list.Description);
        }
    }
}
