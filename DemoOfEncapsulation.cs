using OOPS_Concepts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOPS_Concepts
{
    internal class DemoOfEncapsulation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DemoOfEncapsulation demo = new DemoOfEncapsulation();
          string data=  demo.DemoMethod();
            Console.WriteLine(data);
        }


        public string DemoMethod()
        {
            Demo1 demo = new Demo1();
            demo.Name = "Rajat";
            demo.Age = 25;
            demo.City = "Indore";
            demo.State = "M.P.";
            Console.WriteLine("this is my Data");
            return
                @$"
                   My name Is :{demo.Name} 
                   Age        :{demo.Age}  
                   City       :{demo.City} 
                   State      :{demo.State}                         
                ";
        }
    }

    internal class Demo1
    {

        private  string name ;
      private  int age ;
       private string city;
       private string state;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

       public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }


        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

      


    }
}







