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
    public sealed class QA_Test_Scenario_2_Steps
    {
        IWebDriver driver;

        [Given(@"The ‘Specialist finance and economic data’ link is displayed correctly on the menu item")]
        public void SecGivenINavigateToThePage()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.euromoneyplc.com/our-portfolio/specialist-finance-and-economic-data");
            Assert.AreEqual(true, driver.Url.Equals("http://www.euromoneyplc.com/our-portfolio/specialist-finance-and-economic-data"));

        }

        [When(@"The ‘VISIT IJ GLOBAL’ link navigates to https://ijglobal.com/")]
        public void GivenISeeLinkNavigatesTo()
        {

            IWebElement element = driver.FindElement((By.XPath("//html/body/section/div[5]/div/div/div/div/div[2]/p[2]/a")));
            string path = element.GetAttribute("href");

            Assert.AreEqual("https://ijglobal.com/", path);


        }

        [When(@"The page title is ‘IJGlobal | Infrastructure Journal and Project Finance Magazine’")]
        public void GivenISeeTitlePage()
        {

            driver.Navigate().GoToUrl("https://ijglobal.com/");
            Assert.AreEqual("IJGlobal | Infrastructure Journal and Project Finance Magazine", driver.Title);
        }

        [Then(@"The league table section is displayed on the home page")]
        public void GivenISeeSectionIsDisplayed()
        {

            driver.Navigate().GoToUrl("https://ijglobal.com/");

            IWebElement element = driver.FindElement((By.XPath("//*[@id='collapse']/div[2]/div/ul/li[7]/a")));
            string path = element.GetAttribute("href");

            Assert.AreEqual("https://ijglobal.com/league-tables", path);

        }
    }

}