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
            TodoSequencer.TodoId = 0;
            Assert.Equal(0, TodoSequencer.TodoId);
            Assert.Equal(1, TodoSequencer.NextTodoId());
            Assert.Equal(2, TodoSequencer.NextTodoId());
        }
        [Fact]
        public void ResetTest()
        {
            TodoSequencer.TodoId = 4;
            TodoSequencer.Reset();
            Assert.Equal(0, TodoSequencer.TodoId);
        }
    }
}
