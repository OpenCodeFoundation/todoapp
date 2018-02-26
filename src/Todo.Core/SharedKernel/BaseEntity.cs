using System;
using System.Collections.Generic;
using System.Text;

namespace Techcombd.Todo.Core.SharedKernel
{
    /// <summary>
    /// This can easily be modified to be BaseEntity<T> and public T Id to support different key types.
    /// Using non-generic integer types for simplicity and to ease caching logic
    /// </summary>


    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }
}
