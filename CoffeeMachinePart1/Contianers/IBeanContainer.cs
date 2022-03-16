using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public interface IBeanContainer : IContainer
    {
        public IBean Bean { get; set; }
    }
}
