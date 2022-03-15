using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public abstract class Machine
    {
        protected bool Isbrewing { get; set; }
        public abstract void Start();
        public abstract void Stop();
    }
}
