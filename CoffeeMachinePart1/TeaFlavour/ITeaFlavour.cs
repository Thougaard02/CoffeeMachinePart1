using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public interface ITeaFlavour
    {
        public int AmountOfTeaFlavour { get; set; }
        public TeaFlavours Type { get; set; }
    }
}
