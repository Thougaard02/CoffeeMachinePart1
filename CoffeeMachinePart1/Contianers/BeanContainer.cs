using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public class BeanContainer : IBeanContainer
    {
        public IBean Bean { get; set; }
        public int Size { get; set; }
        public bool IsFull { get; set; }

        public BeanContainer(IBean bean, int size)
        {
            Bean = bean;
            Size = size;
        }
    }
}
