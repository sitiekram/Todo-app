using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Model
{
    public class Todo
    {
        private readonly int todoId;
        private string description;
        private bool done;
        private Person assignee;
        public int TodoId
        {
            get { return todoId; }
        }
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }
        public Person Assignee
        {
            get { return assignee;}
            set { assignee = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Todo(int todoId,string description)
        {
            this.todoId = todoId;
            this.description = description;
        }
    }
}
