using System;
using System.Collections.Generic;

namespace ConsoleApp
{
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
        private List<string> courses = new List<string>()
        {
            "ICT",
            "Pak Studies"
        };

        public bool this[string courseName]
        {
            get {
                return this.courses.IndexOf(courseName.ToUpper()) < 0 ? false : true;
            }
        }

        public bool this[int index, bool CheckRegistrationStatus]
        {
            get {
                if ( getCourseAtIndex(index) != null)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Returns course name registered at specified index
        /// </summary>
        /// <param name="index">Between 0 to N</param>
        /// <returns>Course Name as string if found otherwise Null</returns>
        public string this[int index]
        {
            get { return getCourseAtIndex(index); }
        }

        private string getCourseAtIndex(int index)
        {
            if (index < 0)
                return "Are you crazy? don't you know index starts with 0";
            return index < this.courses.Count ? this.courses[index] : null;
        }

        //public void setInitialCoures()
        //{
        //    this.courses.Add("Computing");
        //    this.courses.Add("Pakistan Studies");
        //}

        public List<string> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

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
}
