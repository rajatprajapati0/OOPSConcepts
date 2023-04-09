using System;

//2) Create a program with Inheritance concept with example.

namespace OOPS_Concepts
{
    internal class DemoOfInheritance
    {
        public static void Main(string[] args) 
        {
            
            Farmer farmerData=new Farmer("Dhoulpur","10","Rajesh","mishra","M.P.","Timarni","India","4564652564562");
            
            Console.WriteLine(farmerData.desplayData());

            Employee employeeData = new Employee(1, "Rakuten", "java", "software dev", "narayan", "Das", "indore", "M.P.","india","45628963333") ;
            Console.WriteLine(employeeData.desplayData());

        }

    }

    public class Person
    {
         
        protected string FirstName;
        protected string LastName;
        protected string city;
        protected string state;
        protected string country;
        protected string Phone;
        public  Person(string FirstName, string LastName, string city, string state, string country, string Phone)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.city = city;
            this.state = state;
            this.country = country;
        }

    }
    sealed class Farmer :Person
    {
        private string village;
        private string landOwnedbyFarmer;
        public Farmer(string village,string landOwnedbyFarmer, string FirstName, string LastName, string city, string state, string country, string Phone) : base(FirstName,LastName,city,state,country,Phone)
        {
        
            this.village = village;
            this.landOwnedbyFarmer = landOwnedbyFarmer;
        }
        public  string desplayData()
        {
            return $@"
                    Farmer Full Name           : {FirstName} {LastName}
                    Farm Land Owned by Farmer  : {landOwnedbyFarmer} acr
                    Vilage                     : {village}
                    City                       : {city}
                    State                      : {state}
                    Country                    : {country} 
";
        }

    }
     sealed class Employee: Person
     {
        private int id;
        private string companyName;
        private string department;
        private string jobPost;
        public Employee(int id, string companyName,string department, string jobPost, string FirstName, string LastName, string city, string state, string country, string Phone) : base(FirstName, LastName, city, state, country, Phone)
        {
            this.id = id;
            this.companyName = companyName;
            this.department = department;
            this.jobPost = jobPost;


        }
        public string desplayData()
        {
            return $@"
                    Emloyee Full Name          : {FirstName} {LastName}
                    Company                    : {companyName}
                    Department                 : {department}
                    Job Post                   : {jobPost}
                    City                       : {city}
                    State                      : {state}
                    Country                    : {country} 
";
        }
    }

}
