using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Techcombd.Todo.Core.Entities;

namespace Todo.Infrastructure.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        { }

        public DbSet<ToDoItem> TodoItems { get; set; }
    }
}
