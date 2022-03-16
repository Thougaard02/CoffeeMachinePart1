using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public class TeaContainer : ITeaContainer
    {
        public ITeaFlavour TeaFlavour { get; set; }
        public int Size { get; set; }
        public bool IsFull { get; set; }

        public TeaContainer(ITeaFlavour teaFlavour, int size)
        {
            TeaFlavour = teaFlavour;
            Size = size;
        }
    }
}
