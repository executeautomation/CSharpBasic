using CSharpBasic.Selenium;

namespace CSharpBasic.ExtensionMethods
{
    public static class WebDriverExtension
    {

        public static void SendKeysWithSplChar(this IWebDriver driver, string keys, string splChar)
        {
            driver.SendKeys(keys);
            driver.SendKeys(splChar);
        }


    }
}
