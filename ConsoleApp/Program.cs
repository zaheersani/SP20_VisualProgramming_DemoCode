using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Args Length: " + args.Length);
            if (args.Length > 0)
            {
                Console.WriteLine("Arguemnt 1: " + args[0]);
                if (args.Length > 1)
                {
                    Console.WriteLine("Arguemnt 2: " + args[1]);
                }
            }

            Student s1 = new Student("Ahmed", 25, "SP12-BCS-098");
            s1.Name = "Zafar";
            //s1.RegNo = "SP12-BCS-098";
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.RegNo);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    public class Student
    {
        private string name;
        private int age;
        public string RegNo { get; set; }

        public Student() : this("", 0, "")
        {
        }
        public Student(string Name, int Age, string RegistrationNo)
        {
            this.name = Name;
            this.age = Age;
            this.RegNo = RegistrationNo;
        }
        public string Name
        {
            get { return this.name;  }
            set
            {
                if(value.Length > 0 && value.Length < 50)
                    this.name = value;
            }
        }
    }

}
