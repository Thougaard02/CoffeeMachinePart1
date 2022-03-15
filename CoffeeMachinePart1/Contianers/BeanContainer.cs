using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public class BeanContainer : IContainer
    {
        public Bean Bean { get; set; }
        public int Size { get; set; }
        public bool IsFull { get; set; }

        public BeanContainer(Bean bean, int size)
        {
            Bean = bean;
            Size = size;
        }
    }
}
