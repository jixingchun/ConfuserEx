using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string para = "Hello,world!";
            PublicMethod1(para);
            Console.ReadLine();
        }

        public static void PublicMethod1(string para1)
        {
            ClassLibraryA.ClassA1 class1 = new ClassLibraryA.ClassA1();
            class1.PublicMethod1(para1);
        }
    }
}
