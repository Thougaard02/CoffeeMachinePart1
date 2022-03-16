using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public interface IBean
    {
        public int AmountOfBeans { get; set; }
        public BeansType Type { get; set; }

    }
}
