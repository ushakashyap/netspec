using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTest.Pages
{
   public class BasePage
    {

        public static IWebDriver BasePageDriver
        {
            get { return WebdriverManager.GetCurrentWebdriverInstance(); }
        }

        public BasePage()
        {
        }

        public IWebElement PageHeader => BasePageDriver.FindElement(By.TagName("H1"));

    }
}
