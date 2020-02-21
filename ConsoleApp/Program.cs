using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //Console.WriteLine(list[0]);
            //list[0] = 111;

            Student s1 = new Student()
            {
                FirstName = "Muhammad",
                 LastName= "Naseem",
                 RegNo = "SP01-BSE-098",
                 DateOfBirth = new DateTime(1993, 3, 4)
            };
            Console.WriteLine(s1.FirstName + " is taking course at " + s1[100, true]);
            string courseToSearch = "ict";
            Console.WriteLine(s1.FirstName + " is taking " + courseToSearch + " :" + s1[courseToSearch]);
            Console.WriteLine("Coures:" + s1.Courses.Count);

            Student s2 = new Student()
            {
                FirstName = "Ali",
                LastName = "Hassan",
                RegNo = "SP01-BSE-090",
                DateOfBirth = new DateTime(1995, 2, 6)
            };
            Faculty f1 = new Faculty()
            {
                FirstName = "Dr. Ahmed",
                LastName = "Khan",
                Department = "Physics",
                Designation = "Associate Professor",
                DateOfBirth = new DateTime(1975, 1, 10)
            };

            Console.WriteLine("Student 1 is equal to Student 2: " + s1.isEqual(s2));
            Console.WriteLine(f1);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    

    public class A
    {
        private int a, b;
        public A()
        {
            this.a = this.b = 0;
        }
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
    public class B : A
    {
        private int c;
        public B() : base()
        {
            this.c = 0;
        }
        public B(int a, int b, int c) : base(a, b)
        {
            this.c = c;
        }
    }

    public class Mobile
    {
        public string Model { get; set; }
        public Battery Battery { get; set; }
    }

    public class Battery
    {
        private string model;
        private string hoursIdle;
        public Battery(string Model, string HourseIdle)
        {
            this.model = Model;
            this.hoursIdle = HourseIdle;
        }
        public string HourseIdle {
            get { return this.hoursIdle; }
        }

        public string Model
        {
            get { return this.model; }
            //set {
            //    if(value != null)
            //        this.model = value;
            //}
        }
    }

}
