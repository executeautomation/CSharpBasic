using CSharpBasic.Browsers;
using CSharpBasic.Selenium;
using System;
using CSharpBasic.ExtensionMethods;
using CSharpBasic.Delegates;
using CSharpBasic.Sharp7;
using System.Linq;


namespace CSharpBasic
{
    enum Browser
    {
        Firefox,
        Chrome,
        IE,
        Safari
    }
    class Program
    {
        //Entry point of your program
        public static void Main(string[] args)
        {

            //Console.WriteLine(GetBrowserName(Browser.IE)); //stronly-typed code

            //IWebDriver driver = new Chrome();

            //driver.SendKeysWithSplChar("executeautomation", "!!!");

            //CollectionExample.GenericCollectionsWithCustomClass();

            ////C# 3.5
            //Func<string, string> p = delegate (string values)
            //{
            //    return values;
            //};

            //Console.WriteLine($"The value from Func<> delegates is this {p("ExecuteAutomation")}");


            //Action<string> actionP = delegate (string values)
            //{
            //    Console.WriteLine($"The value from Action<> delegates is this {values}");
            //};

            //Action<string> actionwithLambda = values => { Console.WriteLine($"The value from Action<> lambda is :{values}"); };

            //actionP("ExecuteAutomation");

            //actionwithLambda("ExecuteAutomation");

            //Delegate Example C# 3.0
            //Printer p = (values) => { Console.WriteLine($"The value printed from Lambda Expression is {values}"); };
            //p("ExecuteAutomation");

            //Delegate Example C# 2.0
            //Printer p = delegate (string values)
            //{
            //    Console.WriteLine($"The value printed inline :{values}");
            //};

            //p("ExecuteAutomation");

            //Delegate Examples - C# 1.0
            //Printer p = DelegateTry.PrintValue1;

            //p("ExecuteAutomation");


            NewFeatures feature = new NewFeatures();

            //feature.GetStudentsInfoWithGrade(feature.student.Where(x => x.Grade == "SuperFirst").First());

            //(string StudentName, int StudentAge, string StudentGrade) = feature.ReturnStudentInfo();

            //if(StudentAge == 40)
            //    Console.WriteLine($"The Student with {StudentName} & Age {StudentAge} & Grade {StudentGrade}");


            //feature.GetStudentsDetailS(out string name, out int age, out string grade);

            //Console.WriteLine($"Student with name {name} has age {age} with grade {grade}");


            Students s = new Students("Karthik");
            
            //Console.WriteLine($"Name of student is: {s.GetStudentName()}");


            s.PrintName();

            Console.Read();

        }



        public static string GetBrowserName(Browser browser)
        {
            if (browser == Browser.Firefox)
                return "firefox is opened";
            else if (browser == Browser.Chrome)
                return "chrome is opened";
            else
                return "IE is opened";
        }

    }

}
