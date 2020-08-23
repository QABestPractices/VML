using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Specialized;
using System.Threading;
using VMLYR.PageObjectModifier;

namespace VMLYR
{
    public class Tests
    {
        [Test]
        public void HeaderNavigationLinks()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                var navLinks = new NavigationLinks(driver);
                 
                navLinks.NavigateToHomePage();

                navLinks.Nav_Icon();

                navLinks.Nav_AboutUs();

                navLinks.Nav_Icon();

                navLinks.Nav_LeaderShip();

                navLinks.Nav_Icon();

                //navLinks.Nav_OurWork();

                //navLinks.Nav_Icon();

                navLinks.Nav_News();

                navLinks.Nav_Icon();

                navLinks.Nav_Insights();

                navLinks.Nav_Icon();

                navLinks.Nav_Careers();

                navLinks.Nav_Icon();

                navLinks.Nav_Locations();

                navLinks.Nav_Icon();

                //navLinks.Nav_ContactUs();
            }
        }
    }
}