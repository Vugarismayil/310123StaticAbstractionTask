using System;

namespace HomeTask31012023Studentclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Vugar Ismayilov",
                GroupNo = "P531"
            };

            Console.WriteLine(student.CheckGroupNo(student.GroupNo)); 


            //int no = student.No;
            //Console.WriteLine($"ID: " + no);
            //Console.WriteLine($"Name:" + student.Name);
            //Console.WriteLine($"GroupNo:" + student.GroupNo);

        }

        

        
    }
}
