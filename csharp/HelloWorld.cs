using System;

namespace Sample
{
    public class HelloWorld
    {
        private int num = 0;

        public HelloWorld()
        {
            num++;
        }

        public static int plus(int a,int b)
        {
            return a+b;
        }

        public int minus(int a,int b)
        {
            return a-b;
        }

        public void display()
        {
            Console.WriteLine("num={0}",num);
        }	
    }
}
