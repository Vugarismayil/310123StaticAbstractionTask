using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace _31012023HomeTask
{
    internal class PersonalComputer : Computer
    {
        public override void DisplayInformation()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Price: " + Price);
        }
    }

}