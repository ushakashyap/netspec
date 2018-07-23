using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTest.Pages
{
   public class BaseSteps
    {

        public static IWebDriver BaseStepsDriver
        {
            get { return WebdriverManager.GetCurrentWebdriverInstance(); }
           
        }

        public BaseSteps()
        {
        }
    }
}
