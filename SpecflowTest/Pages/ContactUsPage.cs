using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecflowTest.Pages
{
    public class ContactUsPage:BasePage
    {
        public ContactUsPage()
        {

        }
        //public IList<IWebElement> Offices => BasePageDriver.FindElements(By.ClassName("contactcities"));
        public IList<IWebElement> Offices => BasePageDriver.FindElements(By.XPath("//ul[@class='contactcities']/li/a[contains(@href,'about')]"));
    }
}
