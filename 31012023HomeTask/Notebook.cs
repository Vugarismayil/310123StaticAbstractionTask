using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _31012023HomeTask
{
    internal class Notebook : Computer
    {
        public override void DisplayInformation()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Price: " + Price);
        }
    }
}
