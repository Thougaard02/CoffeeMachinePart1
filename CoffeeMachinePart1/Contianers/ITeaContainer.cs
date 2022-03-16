using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public interface ITeaContainer : IContainer
    {
        public ITeaFlavour TeaFlavour { get; set; }
    }
}
