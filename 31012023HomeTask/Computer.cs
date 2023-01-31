using System;
using System.Collections.Generic;
using System.Text;

namespace _31012023HomeTask
{
    internal abstract class Computer : IComputer
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public abstract void DisplayInformation();
    }
}
