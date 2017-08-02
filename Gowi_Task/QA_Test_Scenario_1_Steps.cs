using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace Gowi_Task
{
    [Binding]
    public sealed class QA_Test_Scenario_1_Steps
    {
        IWebDriver driver;

        [Given(@"I navigate to the page ""(.*)""")]
        public void GivenINavigateToThePage(string p0)
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.euromoneyplc.com/who-we-are/management-team");
        }

        [When(@"I see the page is loaded")]
        public void GivenISeeThePageIsLoaded()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            Assert.AreEqual(true, driver.Url.Equals("http://www.euromoneyplc.com/who-we-are/management-team"));
        }

        [Then(@"Verify that the URL of the first image is present")]
        public void ImageURLIsPresent()
        {
            IWebElement element = driver.FindElement((By.XPath("/html/body/section/div[2]/div/div/div/div/div/img")));
            string path = element.GetAttribute("src");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));

            Assert.AreEqual("http://euromoneyplc.euromoneycdn.com/v-2f2eace5914d1cfac75dc59309967cb0/Media/Images/omd/em-plc/People/management-team/ARashbass%20picture%20cropped/ARashbass2.jpg", path);
        }

    }

}