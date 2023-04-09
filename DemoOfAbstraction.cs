using System;

//5) Create a program with Abstraction concept.

namespace OOPS_Concepts
{
    internal class DemoOfAbstraction
    {
        public static void Main(string[] args)
        {
            DemoInheritingInterFace demoInheritingInterFace = new DemoInheritingInterFace();
            int sum= demoInheritingInterFace.sumOfTwoNum(5, 6);
            demoInheritingInterFace.example();
            IDemoInterFace demoObj = demoInheritingInterFace;
            demoObj.example();
            demoInheritingInterFace.example();
            IDemoInterFace.StaticEx();
            DemoInheritingInterFace.StaticEx();



            Demo2InheritingInterFace demo2InheritingInterFace = new Demo2InheritingInterFace();
            int sum2 = demo2InheritingInterFace.sumOfTwoNum(5, 6);
            demo2InheritingInterFace.example();
            IDemoInterFace demoObj2 = demo2InheritingInterFace;
            demoObj2.example();
            demo2InheritingInterFace.example();
            IDemoInterFace.StaticEx();
            Demo2InheritingInterFace.StaticEx();
        }

    }


    interface IDemoInterFace 
    {
        int sumOfTwoNum(int a,int b);

        void example() 
        {
            Console.WriteLine("Rajat");
        }
        static void StaticEx() 
        {
            Console.WriteLine("static method");
        }
    
    }
    public class DemoInheritingInterFace :IDemoInterFace
    {
        public int sumOfTwoNum(int a, int b) 
        {
           int c =  a + b;
           return c;
        }
         public void example()
         {
            Console.WriteLine("Prajapati");
         }

        public static void StaticEx()
        {
            Console.WriteLine("static alterd method\n");
        }
    }
    public class Demo2InheritingInterFace : IDemoInterFace
    {
        public int sumOfTwoNum(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public void example()
        {
            Console.WriteLine("Name");
        }

        public static void StaticEx()
        {
            Console.WriteLine("static alterd method");
        }
    }

}
