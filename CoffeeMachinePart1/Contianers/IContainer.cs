using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public interface IContainer
    {
        public int Size { get; set; }
        public bool IsFull{ get; set; }
    }
}
