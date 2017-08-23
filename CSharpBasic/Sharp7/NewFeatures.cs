using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Sharp7
{
    public class NewFeatures
    {
        public List<Students> student = null;

        public NewFeatures()
        {
            var s = new List<Students>
            {
                new Students()
                {
                    Name = "Karthik",
                    Age=20,
                    Gender="M",
                    Grade="First"
                },
                new Students()
                {
                    Name = "Prashanth",
                    Age=15,
                    Gender="M",
                    Grade="First"
                },
                new Students()
                {
                    Name = "Shree",
                    Age=10,
                    Gender="F",
                    Grade="SuperFirst"
                }
            };

            student = s;
        }

        public void GetStudentsInfoWithGrade(Students student)
        {
            switch (student)
            {

                case Students s when (s.Grade == "First" && s.Name.Contains("Kart")):
                    Console.WriteLine($"Student With Name {s.Name} is with Age {s.Age}");
                    break;
                case Students s when (s.Grade == "SuperFirst"):
                    Console.WriteLine($"Student With Name {s.Name} is with Age {s.Age}");
                    break;
                default:
                    break;
            }
        }


        public (string name, int age, string grade) ReturnStudentInfo()
        {
            return ("Karthik", 30, "A");
        }
       

        public void GetStudentsDetailS(out string name, out int age, out string grade)
        {
            name = "Karthik";
            age = 30;
            grade = "A";
        }


    }


    public class Students
    {

        public Students(string name) => Name = name;

        public Students()
        {
                
        }


        private int _salary;

        public int Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Grade { get; set; }

        public string Gender { get; set; }

        public string GetStudentName()
        {
            return Name ?? throw new TypeInitializationException("CSharpBasic.Students.Name",new Exception("Name has to be initialized before calling it"));
        }

        public void PrintName() => Console.WriteLine($"The name of Student is {Name}");
    }
}
