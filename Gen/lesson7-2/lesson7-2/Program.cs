using System;
using System.Collections.Generic;

namespace lesson7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Entity> Test = new List<Entity>()
            {
                new Entity { Id = 1, ParentId = 0, Name = "Root entity"},
                new Entity { Id = 2, ParentId = 1, Name = "Child of 1 entity"},
                new Entity { Id = 3, ParentId = 1, Name = "Child of 1 entity"},
                new Entity { Id = 4, ParentId = 2, Name = "Child of 2 entity"},
                new Entity { Id = 5, ParentId = 4, Name = "Child of 4 entity"},
                new Entity { Id = 6, ParentId = 1, Name = "Child of 1 entity"}
            };
            var Dict = Entity.ToDictionary(Test);
        
        }
    }
}
