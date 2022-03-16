using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public interface ILiquidContainer : IContainer
    {
        public ILiquid Liquid { get; set; }
    }
}
