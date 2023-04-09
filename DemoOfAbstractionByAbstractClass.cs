using System;
//5) Create a program with Abstraction concept.

namespace OOPS_Concepts
{
    internal class DemoOfAbstractionByAbstractClass
    {
        public static void Main(string[] args)
        {
            InheritingDemo inheritingDemo = new InheritingDemo();
            inheritingDemo.name("Rajat");
            inheritingDemo.Sum();
        }
    }
    public abstract class Demo
    {
        public abstract void Sum();
        public abstract void name(string name);
    }

    public class InheritingDemo : Demo
    {

        public override void Sum()
        {
            Console.WriteLine(5 + 6);

        }

        public override void name(string name)
        {
            Console.WriteLine(name);

        }

    }

}
