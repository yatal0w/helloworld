using System;
using Sample;
class Hello
{
    static void Main()
    {
        Console.WriteLine("HelloWorld");
        int a=10,b=20;
        int c=HelloWorld.plus(a,b);
        Console.WriteLine("plus={0}",c);
        HelloWorld hello = new HelloWorld();
        int d=hello.minus(a,b);
        Console.WriteLine("minus={0}",d);
    }
}
