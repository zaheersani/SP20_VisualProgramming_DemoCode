using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student()
            {
                FirstName = "Muhammad",
                 LastName= "Naseem",
                 RegNo = "SP01-BSE-098",
                 DateOfBirth = new DateTime(1993, 3, 4)
            };
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

    public interface IEqual<T>
    {
        bool isEqual(T obj);
    }

    abstract public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        abstract public string getAge();
    }

    public class Student : Person, IEqual<Student>
    {
        public string RegNo { get; set; }

        public override string getAge()
        {
            return this.DateOfBirth.Year.ToString();
        }

        public bool isEqual(Student student)
        {
            return this.RegNo == student.RegNo;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + 
                " RegNo: " + this.RegNo + 
                " DOB: " + this.DateOfBirth.ToString();
        }
    }

    public class Faculty : Person, IEqual<Faculty>
    {
        public string Department { get; set; }
        public string Designation { get; set; }

        public override string getAge()
        {
            throw new NotImplementedException();
        }

        public bool isEqual(Faculty faculty)
        {
            return true;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + 
                " Department: " + this.Department + " Designation: " + this.Designation + 
                " DOB: " + this.DateOfBirth.ToString();
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
