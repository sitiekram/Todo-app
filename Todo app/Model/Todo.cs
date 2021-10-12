﻿using System;
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
