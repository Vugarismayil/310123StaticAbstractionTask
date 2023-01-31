using System;

namespace _31012023HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalComputer PC = new PersonalComputer();
            PC.Brand = "Asus";
            PC.Model = "RT300";
            PC.Price = 2600;

            Notebook Notebook = new Notebook();
            Notebook.Brand = "Lenovo";
            Notebook.Model = "IdeaPad";
            Notebook.Price = 750;

            PC.DisplayInformation();
            Notebook.DisplayInformation();

            

        }
    }
}
