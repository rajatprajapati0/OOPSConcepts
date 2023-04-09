using System;
//3) Create a program with Polymorphism concept along with types of polymorphism.

namespace OOPS_Concepts
{
    internal class DemoPolymorphism
    {
        public static void Main(string[]arg)
        {
           //EX. MethodOverriding
            //calling sum method by object of  MethodOverriding class
            MethodOverriding methodOverriding = new MethodOverriding();
            methodOverriding.sum();

            //calling sum method by object of  MethodOverridingDEmo2  class it is inherting MethodOverriding class 
            MethodOverridingDEmo2 methodOverriding2 = new MethodOverridingDEmo2();
            methodOverriding2.sum();

            //calling sum method by child MethodOverridingDEmo2 class object 

            MethodOverriding demo = methodOverriding2;
            demo.sum();
            MethodOverriding demo2= new MethodOverridingDEmo2();
            demo2.sum();

            //EX.MethodOverLoading
            MethodOverLoading methodOverLoading = new MethodOverLoading();
            
            methodOverLoading.sum(6);

            methodOverLoading.sum(4, 5);


        }
        public class MethodOverriding 
        { 
            public virtual void sum() 
            {
                Console.WriteLine("Addition example for Method overriding \n" + (2+3));
            }

        }
        public class MethodOverridingDEmo2 : MethodOverriding
        {
            public override void sum()
            {
                Console.WriteLine("Subtraction example for Method overriding \n" + (5 - 2));
            }

        }

        public class MethodOverLoading
        {       

            public void sum(int a)
            {
                Console.WriteLine("Addition example for Method overloading single parameter\n " + (a + 3));
            }
            public void sum(int a ,int b)
            {
                Console.WriteLine("Addition example for Method overloading multi parameter\n " + (a + b));

            }
        }

    }
}
