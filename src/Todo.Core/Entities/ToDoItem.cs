using System;
using System.Collections.Generic;
using System.Text;
using Techcombd.Todo.Core.SharedKernel;

namespace Techcombd.Todo.Core.Entities
{
    public class ToDoItem : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}
