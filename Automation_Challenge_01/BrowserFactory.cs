using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;

namespace Automation_Challenge
{
    public class BrowserFactory
    {
        
        public static IWebDriver StartBrowser(string url, string title)
        {
            IWebDriver GCdriver = new ChromeDriver();
            GCdriver.Manage().Window.Maximize();
            GCdriver.Navigate().GoToUrl(url);
            Assert.AreEqual(title, GCdriver.Title);

            return GCdriver;

        }

        public static IWebDriver PhantomBrowser(string url)
        {
            IWebDriver Pdriver = new PhantomJSDriver();

           // Pdriver.Manage().Window.Maximize();
            Pdriver.Navigate().GoToUrl(url);
            return Pdriver;

        }
    }
}