using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Data;
using Xunit;

namespace Todo_app.Tests.DataTests
{
    public class TodoSequencerTests
    {

        [Fact]
        public void NextTodoIdTest()
        {
            int todoIdNow = TodoSequencer.TodoId;
            int testTodoId = TodoSequencer.NextTodoId();
            Assert.Equal(todoIdNow + 1, testTodoId);
        }
        [Fact]
        public void ResetTest()
        {
            TodoSequencer.Reset();
            Assert.Equal(0, TodoSequencer.TodoId);
        }
    }
}
