using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public abstract class Bean : IBean
    {
        public BeansType Type { get; set; }
        public int AmountOfBeans { get; set; }
        public Bean(int amountOfBeans)
        {
            AmountOfBeans = amountOfBeans;
        }
    }
}