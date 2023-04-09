using System;

namespace OOPS_Concepts
{
    internal class DemoOFObject
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DemoObject demo = new DemoObject();
            
            string Data=demo.DemoMethodForObject();
            Console.WriteLine(Data);
        }
    }
    internal class DemoObject
    {
       
        string name = "Rajat";
        int age = 25;
        string city = "Indore";
        string state = "M.P.";
      
        public string DemoMethodForObject()
        {
            Console.WriteLine("this is my Data");
            return
                @$"
                   My name Is :{name} 
                   Age        :{age}  
                   City       :{city} 
                   State      :{state}                         
                ";
        }


    }
}
