using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public class TeaMachine : Machine
    {
        private const int LIQUID_CONTAINER_SIZE = 20;
        private const int TEA_CONTAINER_SIZE = 20;
        private ILiquidContainer _liquidContainer { get; set; }
        private ITeaContainer _teaContainer { get; set; }
        public TeaMachine(ILiquid liquid, ITeaFlavour teaFlavour)
        {
            _liquidContainer = new LiquidContainer(liquid, LIQUID_CONTAINER_SIZE);
            _teaContainer = new TeaContainer(teaFlavour, TEA_CONTAINER_SIZE);
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
            Console.WriteLine($"Enjoy your tea");
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
            while (!_teaContainer.IsFull)
            {
                _teaContainer.Size -= _teaContainer.TeaFlavour.AmountOfTeaFlavour;
                Console.WriteLine("Pouring tea flavour into tea container");
                if (_teaContainer.Size <= 0)
                {
                    _teaContainer.IsFull = true;
                    Console.WriteLine("Tea flavour container is full");
                }
            }
        }
        private bool IsReadyToBrew()
        {
            if (_liquidContainer.IsFull && _teaContainer.IsFull)
            {
                return true;
            }
            return false;
        }
    }
}
