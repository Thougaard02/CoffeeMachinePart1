using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public class CoffeeBean : Bean
    {
        public CoffeeBean(int amountOfBeans) : base(amountOfBeans)
        {
            Type = BeansType.CoffeeBeans;
        }
    }
}
