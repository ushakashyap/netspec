using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecflowTest.Pages
{
    public class ValtechHomePage:BasePage
    {
        public ValtechHomePage()
        {

        }
        public IWebElement AboutLink => BasePageDriver.FindElement(By.LinkText("ABOUT"));
        public IWebElement WorkLink => BasePageDriver.FindElement(By.LinkText("WORK"));
        public IWebElement ServicesLink => BasePageDriver.FindElement(By.LinkText("SERVICES"));
        public IWebElement LatestNewsHeading => BasePageDriver.FindElement(By.ClassName("news-post__listing-header"));
        public IWebElement LatestNewsSection => BasePageDriver.FindElement(By.ClassName("bloglisting news-post__listing"));
        public IWebElement ContactUs => BasePageDriver.FindElement(By.Id("contacticon"));



    }
}
