using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Automation_Challenge
{
    [TestClass]
    public class UnitTest2
    {
        public static TestContext testContextInstance;

        //reerences for our browser
        private string siteName = "https://www.skiutah.com";
        private string homeTitle = "Ski Utah - Ski Utah";
        private string searchPage = "https://www.skiutah.com/members/listing";
        private string searchTitle = "All Services - Ski Utah";
        private string resortName = "Deer Valley";

        private string whatPara = "Transportation";
        private string resortPara = "Brian Head";
        private string subcategoryPara = "Group Shuttles";

        //private static FileStream fs2 = new FileStream("F:\\Screenshot\\Linkvisited.txt", FileMode.OpenOrCreate, FileAccess.Write);
        //private static StreamWriter writer2 = new StreamWriter(fs2);
       
      

        public TestContext TestContext
        {
            get
            {
                return testContextInstance; 
            }
            set
            {
                testContextInstance = value;
            }
        }


        [TestMethod]
        public void Challenge4_resort_gettime()
        {
            IWebDriver driver = BrowserFactory.StartBrowser(siteName, homeTitle);

            IWebElement homepageImage = driver.FindElement(By.ClassName("map-Slate-img"));
            homepageImage.Click();
                
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4000));

            By reqResort = BackgroundTask.identifyResort(driver, resortName);

            if (BackgroundTask.IsElementDisplayed(driver, reqResort) &&
                BackgroundTask.IsElementEnabled(driver, reqResort))
            {
                driver.FindElement(reqResort).Click();
            }

            IWebElement resortTime = driver.FindElement(BackgroundTask.calculate_time_to_resort(driver, resortName));
            
            string reqTime = resortTime.Text;
            
            //Output can be seen in test explorer output section
            TestContext.WriteLine(reqTime);
            TestContext.WriteLine(resortName +" is " + reqTime + " minutes away from Airport.");
        }

        [TestMethod]
        public void Challenge5_search_getinfo()
        {
            IWebDriver driver = BrowserFactory.StartBrowser(searchPage, searchTitle);
           
            List<IWebElement> srchResult = BackgroundTask.dropdownSearch(driver, whatPara, resortPara, subcategoryPara);

            TestContext.WriteLine("\n"+ srchResult.Count+ " Search Results\n");

            foreach (IWebElement result in srchResult)
            {
                string pp = result.FindElement(By.TagName("h3")).Text;
                TestContext.WriteLine(pp);
            }

        }

        [TestMethod]
        public void Challenge6_crawler()
        {

            IWebDriver driver = BrowserFactory.StartBrowser(siteName,homeTitle);
            
            // link to save link visited
            List<string> linkVisited = new List<string>();
            
            linkVisited = CrawlerClass.Crawler(driver);
               
            TestContext.WriteLine(linkVisited.Count.ToString());
            //writer2.Write(linkVisited.Count + " links visited " + Environment.NewLine);
            foreach (string stg in linkVisited)
            {
                TestContext.WriteLine(stg);
                //writer2.Write(stg + Environment.NewLine);
            }
            //writer2.Close();
        }


    }
}
