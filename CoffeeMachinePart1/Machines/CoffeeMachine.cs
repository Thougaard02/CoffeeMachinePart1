using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public class CoffeeMachine : Machine
    {
        private const int LIQUID_CONTAINER_SIZE = 20;
        private const int BEAN_CONTAINER_SIZE = 20;
        private LiquidContainer _liquidContainer { get; set; }
        private BeanContainer _beanContainer { get; set; }
        public CoffeeMachine(Liquid liquid, Bean bean)
        {
            _liquidContainer = new LiquidContainer(liquid, LIQUID_CONTAINER_SIZE);
            _beanContainer = new BeanContainer(bean, BEAN_CONTAINER_SIZE);
        }
        public override void Start()
        {
            Isbrewing = true;
            if (Isbrewing)
            {
                IsReadyToBrew();
                Console.WriteLine("Brewing has started");
            }
        }
        public override void Stop()
        {
            Isbrewing = false;
            Console.WriteLine("Brewing is finsihed");
            Console.WriteLine($"Enjoy your coffee");
        }

        public void PourLiquidIntoContainer()
        {
            while (!_liquidContainer.IsFull)
            {
                Console.WriteLine("Pouring Liquid into liquid container");
                _liquidContainer.Size -= _liquidContainer.Liquid.AmountOfLiquid;
                if (_liquidContainer.Size <= 0)
                {
                    _liquidContainer.IsFull = true;
                    Console.WriteLine("Liquid container is full");
                }
            }
        }
        public void PourBeansIntoContainer()
        {
            while (!_beanContainer.IsFull)
            {
                _beanContainer.Size -= _beanContainer.Bean.AmountOfBeans;
                Console.WriteLine("Pouring beans into beans container");
                if (_beanContainer.Size <= 0)
                {
                    _beanContainer.IsFull = true;
                    Console.WriteLine("Beans container is full");
                }
            }
        }
        private bool IsReadyToBrew()
        {
            if (_liquidContainer.IsFull && _beanContainer.IsFull)
            {
                return true;
            }
            return false;
        }
    }
}
