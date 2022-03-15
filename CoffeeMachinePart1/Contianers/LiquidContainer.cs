using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public class LiquidContainer : IContainer
    {
        public Liquid Liquid { get; set; }
        public int Size { get; set; }
        public bool IsFull { get; set ; }

        public LiquidContainer(Liquid liquid, int size)
        {
            Liquid = liquid;
            Size = size;
        }
    }
}
