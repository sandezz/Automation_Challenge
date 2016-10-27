using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace Automation_Challenge
{
    [TestClass]
    public class UnitTest1
    {
        // create reference for our browser
        private string siteName = "https://www.skiutah.com";
        private string homeTitle = "Ski Utah - Ski Utah";
        private string menu_title = "Deals";
        private string submenuTitle = "Food + Drink";
  
       
       [TestMethod]
        public void Challange1_login()
       {
           IWebDriver driver = BrowserFactory.StartBrowser(siteName,homeTitle);
           Assert.AreEqual(homeTitle, driver.Title);
           //driver.FindElement(By.PartialLinkText("Plan")).Click();
           //driver.Quit();
        }
        

        [TestMethod]
       public void Challenge2_navigation_menu()
        {
            IWebDriver driver = BrowserFactory.StartBrowser(siteName, homeTitle);
            
            // selecting menu
            IWebElement link_menu = BackgroundTask.identify_menu(driver, menu_title);
            
            //perform click operation on homepage menu
            Actions action = new Actions(driver);
            action.MoveToElement(link_menu).Click().Perform();

            
            //scroll down
            IWebElement foot = driver.FindElement(By.Id("footer"));
            action.MoveToElement(foot).Perform();
        }


        [TestMethod]
        public void Challenge3_navigation_submenu()
        {
            IWebDriver driver = BrowserFactory.StartBrowser(siteName, homeTitle);
            
            IWebElement link_menu = BackgroundTask.identify_menu(driver, menu_title);

            //perform hover operation
            Actions action = new Actions(driver);
            action.MoveToElement(link_menu).Perform();
            
            if (menu_title != "Stories")
            {
                switch (submenuTitle)
                {
                    case "Lodging": 
                    {
                        if (menu_title == "Deals")
                            submenuTitle = "Lodging1";
                        else
                        {
                            if (menu_title == "Explore")
                                submenuTitle = "Lodging2";
                        }
                        break;
                    }
                    case "Transportation":
                    {
                        if (menu_title == "Deals")
                            submenuTitle = "Transportation1";
                        break;
                    }
                    case "Activities":
                    {
                        if (menu_title == "Explore")
                            submenuTitle = "Activities1";
                        break;
                    }
                    case "Food + Drink":
                    {
                        if (menu_title == "Explore")
                            submenuTitle = "Food + Drink1";
                        break;
                    }
                }

               IWebElement linkSubmenu = BackgroundTask.identify_submenu(driver, submenuTitle);
               action.MoveToElement(linkSubmenu).Click().Perform(); 
            }
         }

    }
}
