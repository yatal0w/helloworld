using System;
namespace HelloWorld
{
    class HelloWorld
    {
        static void Main()
        {
            Console.WriteLine("HelloWorld");
            int a=10,b=20;
            int c=plus(a,b);
            Console.WriteLine("plus={0}",c);
            HelloWorld hello = new HelloWorld();
            int d=hello.minus(a,b);
            Console.WriteLine("minus={0}",d);
        }

        static int plus(int a,int b)
        {
            return a+b;
        }

        int minus(int a,int b)
        {
            return a-b;
        }
    }
}
