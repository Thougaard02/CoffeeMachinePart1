using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public abstract class Liquid
    {
        public int AmountOfLiquid { get; set; }
        public LiquidType Type { get; set; }
        public Liquid(int amountOfLiquid)
        {
            AmountOfLiquid = amountOfLiquid;
        }
    }
}
