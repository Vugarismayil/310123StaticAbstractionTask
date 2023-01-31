using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace HomeTask31012023Studentclass
{
    internal class Student
    {
        private static int counter = 0;
        public int No { get; private set; }
        public string Name { get; set; }
        public string GroupNo { get; set; }
        public Student()
        {
            No = ++counter;
        }
        public bool CheckGroupNo(string groupno)
        {
            if (groupno.Length ==4 &&  char.IsUpper(groupno[0]))
            {
                for (int i = 1; i < groupno.Length; i++)
                {
                    if(!char.IsDigit(groupno[i]))
                    {
                        return false;
                    }
                }
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
