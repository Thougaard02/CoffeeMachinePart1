using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public abstract class TeaFlavour : ITeaFlavour
    {
        public int AmountOfTeaFlavour { get; set; }

        public TeaFlavour(int amountOfTeaFlavour)
        {
            AmountOfTeaFlavour = amountOfTeaFlavour;
        }
    }
}
