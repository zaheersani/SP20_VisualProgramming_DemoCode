using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10, b = 0;
            //a = int.Parse(Console.ReadLine());
            Console.WriteLine(a / b);
            //Console.WriteLine(10 / 0);

            Employee emp1 = new Employee()
            {
                Name = "Zaheer",
                Department = "Computer Science",
                Tasks = new List<DeptTask>()
                {
                    new DeptTask("C1", 2, "Take Lab Today"),
                    new DeptTask("C2", 3, "Having FYP Meeting"),
                    new DeptTask("C3", 1, "Schedule Lab Tomorrow"),
                    new DeptTask("C4", 1, "Take FYP Evaluation"),
                }
            };

            Console.WriteLine(emp1[1].Description);
            string taskCode = "C1";
            Console.WriteLine("Task Details having Code:{0}", taskCode);
            Console.WriteLine("Description:{0}",emp1[taskCode].Description);
            Console.WriteLine("Priority:{0}",emp1[taskCode].Priority);
            Console.WriteLine("------------");

            string taskDesc = "FYP";
            Console.WriteLine("Task Details having Description:{0}", taskDesc);
            List<DeptTask> tasks = emp1[taskDesc,true];
            foreach (DeptTask item in tasks)
            {
                //Console.WriteLine("Task List having Description:" + taskDesc);
                Console.WriteLine("Code:" + item.Code);
                Console.WriteLine("Priority:" + item.Priority);
                Console.WriteLine("Description:" + item.Description);
            }

            Console.ReadKey();
            return;

            Box b1 = new Box(2,2,2);
            Box b2 = new Box(1,1,1);
            if(b2 > b1)
                Console.WriteLine("box1 is greater than box2");
            else
                Console.WriteLine("box1 is smaller than box2");

            Console.WriteLine("Addition: " + (b1 + b2).getVolume());
            Console.ReadKey();
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
