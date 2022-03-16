using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public class LiquidContainer : ILiquidContainer
    {
        public ILiquid Liquid { get; set; }
        public int Size { get; set; }
        public bool IsFull { get; set ; }

        public LiquidContainer(ILiquid liquid, int size)
        {
            Liquid = liquid;
            Size = size;
        }
    }
}
