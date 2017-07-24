using CSharpBasic.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Browsers
{
    class Chrome : IWebDriver
    {
        public void FindElement()
        {
            Console.WriteLine("Find the UI element in chrome");
        }

        public void Click()
        {
            Console.WriteLine("Click the element");
        }

        public void SendKeys(string keys)
        {
            Console.WriteLine("Send the text " + keys);
        }

        

       
    }
}
