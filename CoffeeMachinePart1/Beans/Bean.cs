﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachinePart1
{
    public abstract class Bean
    {
        public int AmountOfBeans { get; set; }
        public Bean(int amountOfBeans)
        {
            AmountOfBeans = amountOfBeans;
        }
    }
}