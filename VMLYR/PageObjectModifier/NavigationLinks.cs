using OpenQA.Selenium;
using System;
using System.Threading;

namespace VMLYR.PageObjectModifier
{
    class NavigationLinks
    {
        private readonly IWebDriver Driver;
        private const string PageURL = "https://www.vmlyr.com/";

        #region navigation_locators
        public void Nav_Icon()
        {
            Driver.FindElement(By.CssSelector("button[title='Open navigation'] > svg")).Click();
            Thread.Sleep(1000);
        }
        public void Nav_AboutUs()
        {
            Driver.FindElement(By.CssSelector("div[role='dialog'] a[title='About VMLY&R']")).Click();
            string title = "About Us - #WeAreVMLYR | VMLY&R";
            EnsureHomePageLoaded(title);
        }

        public void Nav_LeaderShip()
        {
            Driver.FindElement(By.CssSelector("div[role='dialog'] a[title='Meet the People behind VMLY&R']")).Click();
            string title = "Meet the Leadership Team | VMLY&R";
            EnsureHomePageLoaded(title);
        }

        public void Nav_OurWork()
        {
            Driver.FindElement(By.XPath("(//a[contains(text(),'Our Work')])[1]")).Click();
            string title = "Our Work | VMLY&R";
            EnsureHomePageLoaded(title);
        }

        public void Nav_News()
        {
            Driver.FindElement(By.CssSelector("div[role='dialog'] a[title='The latest news from VMLY&R']")).Click();
            string title = "News | VMLY&R";
            EnsureHomePageLoaded(title);
        }

        public void Nav_Insights()
        {
            Driver.FindElement(By.CssSelector("div[role='dialog']  ul > li:nth-of-type(6) > a")).Click();
            string title = "Insights";
            EnsureHomePageLoaded(title);
        }

        public void Nav_Careers()
        {
            Driver.FindElement(By.CssSelector("div[role='dialog'] a[title='Work at VMLY&R']")).Click();
            string title = "Careers";
            EnsureHomePageLoaded(title);
        }

        public void Nav_Locations()
        {
            Driver.FindElement(By.CssSelector("div[role='dialog']  ul > li:nth-of-type(8) > a")).Click();
            string title = "Global Offices and Locations | VMLY&R";
            EnsureHomePageLoaded(title);
        }

        public void Nav_ContactUs()
        {
            Driver.FindElement(By.XPath("(//a[contains(text(),'Contact Us')])[1]")).Click();
            string title = "Contact Us";
            EnsureHomePageLoaded(title);
        }
        #endregion

        public NavigationLinks(IWebDriver driver)
        {
            Driver = driver;
        }

        public void NavigateToHomePage()
        {
            Driver.Navigate().GoToUrl(PageURL);
            Driver.Manage().Window.Maximize();
            String title = "VMLY&R | VMLY&R | Global Brand and Customer Experience Agency";
            EnsureHomePageLoaded(title);
        }

        private void EnsureHomePageLoaded(string title)
        {
            bool pageHasLoaded = (Driver.Title == title);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed due to page Title mismatch: \r\n Expected Title:'{title}' \r\n Actual Title:'{Driver.Title}'");
            }
        }
    }
}
