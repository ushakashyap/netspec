using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace SpecflowTest.Pages
{
   public static class WebdriverManager
    {

        public static IWebDriver webDriver;
       

        public static void InitialiseWebdriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-fullscreen");
            webDriver = new OpenQA.Selenium.Chrome.ChromeDriver(options);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //Console.WriteLine("initialise webdriver");
        }

        public  static IWebDriver GetCurrentWebdriverInstance()
        {
            return webDriver;
        }
      
    }
}
