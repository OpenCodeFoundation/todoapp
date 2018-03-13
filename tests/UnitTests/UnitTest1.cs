using System;
using Techcombd.Todo.Core.Entities;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Trait("Category", "UnitTest")]
        [Fact]
        public void Test1()
        {
            Assert.Equal(2, 2);
        }

        [Trait("Category", "ModelTest")]
        [Fact]
        public void TodoItemModelShouldHaveDateCreationField()
        {
            var todoItem = new ToDoItem
            {
                Title = "Sample Task",
                Description = "Simple discription",
                IsDone = false
            };

            var result = todoItem.CreateDate;
            Assert.NotEqual(default(DateTime), result);
        }
    }
}
