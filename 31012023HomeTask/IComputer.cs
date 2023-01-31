using System;
using System.Collections.Generic;
using System.Text;

namespace _31012023HomeTask
{
    internal interface IComputer
    {   string Brand { get; set; }
        string Model { get; set; }
        double Price { get; set; }

        void DisplayInformation();
    }
}
