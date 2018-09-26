using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
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
            SampleClass sampleClass = new SampleClass();
            string para = "PublicMethod1";
            bool ret = sampleClass.DoSomething(para);
            Console.WriteLine("excute result is " + ret);
        }

        private static void PrivateMethod1(string para1)
        {
            SampleClass sampleClass = new SampleClass();
            string para = "PrivateMethod1";
            bool ret = sampleClass.DoSomething(para);
            Console.WriteLine("excute result is " + ret);
        }
    }

    public class SampleClass
    {
        public bool DoSomething(string para)
        {
            Console.WriteLine("start do something " + para);
            int sum =0;
            for(int i = 1; i<=10;i++)
            {
                sum += i;
            }

            return true;
        }
    }
        
}
