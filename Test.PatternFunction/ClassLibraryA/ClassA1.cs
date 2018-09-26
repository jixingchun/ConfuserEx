using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryA
{
    public class ClassA1
    {
        public void PublicMethod1(string para1)
        {
            ClassLibraryB.ClassB1 class1 = new ClassLibraryB.ClassB1();
            class1.PublicMethod1(para1);
        }

        public void PublicMethod2(string para1)
        {
            Console.WriteLine(para1);
        }

        private void PrivateMethod1(string para1)
        {
            Console.WriteLine(para1);
        }

        private void PrivateMethod2(string para1)
        {
            Console.WriteLine(para1);
        }
    }
}
