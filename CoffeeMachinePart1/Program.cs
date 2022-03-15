using System;

namespace CoffeeMachinePart1
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine(new Milk(10), new CoffeeBean(10));
            coffeeMachine.PourBeansIntoContainer();
            coffeeMachine.PourLiquidIntoContainer();
            coffeeMachine.Start();
            coffeeMachine.Stop();
        }
    }
}
