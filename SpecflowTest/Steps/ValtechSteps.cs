using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using SpecflowTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowTest.Steps
{
    [Binding]
    public class SpecFlowFeature1Steps : Pages.BaseSteps
    {
       
        [Given(@"I am on the Valtech home page")]
        public void GivenIAmOnTheValtechHomePage()
        {
            WebdriverManager.GetCurrentWebdriverInstance().Url = "https://www.valtech.com/";
        }

        [Then(@"I see the latest news section")]
        public void ThenISeeTheLatestNewsSection()
        {
            ValtechHomePage valtechHomePage = new ValtechHomePage();
            Assert.IsTrue(valtechHomePage.LatestNewsHeading.Displayed);
        }

        [When(@"I select the (.*) in the top navigation")]
        public void WhenISelectTheInTheTopNavigation(string p0)
        {
            ValtechHomePage valtechHomePage = new ValtechHomePage();
            if(p0.Equals("ABOUT"))
            {
                valtechHomePage.AboutLink.Click();
                
            }
            else if (p0.Equals("WORK"))
            {
                valtechHomePage.WorkLink.Click();

            }
            else if (p0.Equals("SERVICES"))
            {
                valtechHomePage.ServicesLink.Click();

            }
        }

        [Then(@"I should be shown the (.*) page with correct heading (.*)")]
        public void ThenIShouldBeShownThePageWithCorrectHeading(string p0, string p1)
        {
            ValtechHomePage valtechHomePage = new ValtechHomePage();
            Assert.AreEqual(valtechHomePage.PageHeader.Text, p1);

        }

        [When(@"I navigate to the contact page")]
        public void WhenINavigateToTheContactPage()
        {
            ValtechHomePage valtechHomePage = new ValtechHomePage();
            valtechHomePage.ContactUs.Click();
            
        }

        [Then(@"I see x valtech offices")]
        public void ThenISeeXValtechOffices()
        {
            ContactUsPage contactUsPage = new ContactUsPage();
            System.Diagnostics.Debug.WriteLine(contactUsPage.Offices.Count);
        }

    }
}
