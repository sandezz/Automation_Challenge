using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Automation_Challenge
{
    public class BackgroundTask
    {

        public static TestContext TestContext
        {
            get
            {
                return TestContextInstance;
            }
            set
            {
                TestContextInstance = value;
            }
        }

        public static TestContext TestContextInstance;

        public static IWebElement identify_menu(IWebDriver driver, string title)
        {
           IWebElement link_menu = driver.FindElement(By.ClassName("icon"));

            switch (title)
            {
                case "Plan your trip":
                    {
                        link_menu = driver.FindElements(By.ClassName("icon"))[0];
                        break;
                    }
                case "Resorts & Snow":
                    {
                        link_menu = driver.FindElements(By.ClassName("icon"))[1];
                        break;
                    }
                case "Stories":
                    {
                        link_menu = driver.FindElements(By.ClassName("icon"))[2];
                        break;
                    }
                case "Deals":
                    {
                        link_menu = driver.FindElements(By.ClassName("icon"))[3];
                        break;
                    }
                case "Passes":
                    {
                        link_menu = driver.FindElements(By.ClassName("icon"))[4];
                        break;
                    }
                case "Explore":
                    {
                        link_menu = driver.FindElements(By.ClassName("icon"))[5];
                        break;
                    }
            }

            return link_menu;
        }


       public static IWebElement identify_submenu(IWebDriver driver, string subtitle)
        {
            IWebElement submenu = driver.FindElement(By.ClassName("SuperfishMegaMenu-subLink "));
            switch (subtitle)
            {
                case "Activities":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[1];
                    break;
                }
                case "Food + Drink":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[2];
                    break;
                }
                case "Lodging":
                {
                    
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[3];
                    break;
                }
                case "Retail + Rental":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[4];
                    break;
                }
                case "Reservation Experts":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[5];
                    break;
                }
                case "Ski Resorts":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[6];
                    break;
                }
                case "Ski School":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[7];
                    break;
                }
                case "Transportation":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[8];
                    break;
                }
                case "Utah Events":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[9];
                    break;
                }
                case "Photos":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[11];
                    break;
                }
                case "Videos":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[12];
                    break;
                }
                case "Stories":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[13];
                    break;
                }
                case "Compare Resorts":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[14];
                    break;
                }
                case "resort Comparison":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[16];
                    break;
                }
                case "Alta":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[17];
                    break;
                }
                case "Beaver Mountain":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[18];
                    break;
                }
                case "Brian Head":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[19];
                    break;
                }
                case "Brighton":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[20];
                    break;
                }
                case "Cheery Peak":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[21];
                    break;
                }
                case "Deer Valley":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[22];
                    break;
                }
                case "Eagle Point":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[23];
                    break;
                }
                case "Nordic Valley":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[24];
                    break;
                }
                case "Park City":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[25];
                    break;
                }
                case "Powder Mountain":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[26];
                    break;
                }
                case "Snowbasin":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[27];
                    break;
                }
                case "Snowbird":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[28];
                    break;
                }
                case "Solitude":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[29];
                    break;
                }
                case "Sundance":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[30];
                    break;
                }
                case "Cross Country - Nordic Locations":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[31];
                    break;
                }
                case "Snow Report":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[33];
                    break;
                }
                case "Mobile App & TV Display":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[34];
                    break;
                }
                case "Live Mountain Cams":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[35];
                    break;
                }
                case "Printable Snow Report":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[36];
                    break;
                }
                case "Why Utah Snow?":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[37];
                    break;
                }
                case "All Trail Maps":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[38];
                    break;
                }
                case "All Deals":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[40];
                    break;
                }
                case "Lodging1":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[41];
                    break;
                }
                case "Retail & Rental":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[42];
                    break;
                }
                case "Transportation1":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[43];
                    break;
                }
                case "Learn to Ski Program":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[45];
                    break;
                }
                case "Beginner":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[46];
                    break;
                }
                case "Purchase Utah Lift Tickets":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[47];
                    break;
                }
                case "5th & 6th Grade Passport":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[48];
                    break;
                }
                case "Ski Utah Yeti Pass":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[49];
                    break;
                }
                case "Buy The Silver and Gold Passes":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[50];
                    break;
                }
                case "2016-17 Season Passes":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[51];
                    break;
                }
                case "Military and Senior Day Ski Pass Prices":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[52];
                    break;
                }
                case "Stories - Photos - Videos":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[54];
                    break;
                }
                case "Interconnect Adventure Tour":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[55];
                    break;
                }
                case "Utah Areas 101":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[56];
                    break;
                }
                case "Getting To Utah Resorts":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[57];
                    break;
                }
                case "Snow":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[58];
                    break;
                }
                case "Activities1":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[59];
                    break;
                }
                case "Food + Drink1":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[60];
                    break;
                }
                case "Lodging2":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[61];
                    break;
                }
                case "Backcountry Skiing":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[62];
                    break;
                }
                case "Terrain Parks":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[63];
                    break;
                }
                case "Ski Utah Magazine":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[65];
                    break;
                }
                case "eNewsletter & Snowmail":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[66];
                    break;
                }
                case "Compare All Resorts":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[67];
                    break;
                }
                case "Real Estate":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[68];
                    break;
                }
                case "Ski Bus":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[69];
                    break;
                }
                case "Join Ski Utah":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[70];
                    break;
                }
                case "Ski Utah Membership":
                {
                    submenu = driver.FindElements(By.ClassName("SuperfishMegaMenu-subLink "))[71];
                    break;
                }    
            }

           return submenu;
        }

       //is Element Displayed
       public static bool IsElementDisplayed(IWebDriver driver,By element)
       {
           
           if (driver.FindElements(element).Count > 0)
           {
               if (driver.FindElement(element).Displayed)
                   return true;
               else
                   return false;
           }
           else
           {
               return false;
           }
       }

       //is Element Enabled
       public static bool IsElementEnabled(IWebDriver driver, By element)
       {
           if (driver.FindElements(element).Count > 0)
           {
               if (driver.FindElement(element).Enabled)
                   return true;
               else
                   return false;
           }
           else
           {
               return false;
           }
       }

       public static By identifyResort(IWebDriver driver, string Rname)
        {
            By linkResort = By.Id("header");


            switch (Rname)
            {
                case "Beaver Mountain":
                {
                    linkResort = By.CssSelector("label.map-Area-label--beaver-mountain");
                    break;
                }
                case "Cherry Peak":
                {
                    linkResort = By.CssSelector("label.map-Area-label--cherry");
                    break;
                }
                case "Powder Mountain":
                {
                    linkResort = By.CssSelector("label.map-Area-label--powder-mountain");
                    break;
                }
                case "Nordic Valley":
                {
                    linkResort = By.CssSelector("label.map-Area-label--nordic-valley");
                    break;
                }
                case "Snowbasin":
                {
                    linkResort = By.CssSelector("label.map-Area-label--snowbasin");
                    break;
                }
                case "Park City":
                {
                    linkResort = By.CssSelector("label.map-Area-label--park-city-mountain");
                    break;
                }
                case "Deer Valley":
                {
                    linkResort = By.CssSelector("label.map-Area-label--deer-valley");
                    break;
                }
                case "Brighton":
                {
                    linkResort = By.CssSelector("label.map-Area-label--brighton");
                    break;
                }
                case "Solitude":
                {
                    linkResort = By.CssSelector("label.map-Area-label--solitude");
                    break;
                }
                case "Alta":
                {
                    linkResort = By.CssSelector("label.map-Area-label--alta");
                    break;
                }
                case "Snowbird":
                {
                    linkResort = By.CssSelector("label.map-Area-label--snowbird");
                    break;
                }
                case "Sundance":
                {
                    linkResort = By.CssSelector("label.map-Area-label--sundance");
                    break;
                }
                case "Eagle Point":
                {
                    linkResort = By.CssSelector("label.map-Area-label--eagle-point");
                    break;
                }
                case "Brian Head":
                {
                    linkResort = By.CssSelector("label.map-Area-label--brian-head");
                    Actions action = new Actions(driver);
                    action.MoveToElement(driver.FindElement(linkResort)).Perform();
                    break;
                }
            }
            return linkResort;
        }

        
        
        public static By calculate_time_to_resort(IWebDriver driver, string name)
        {
            By resortTime = By.Id("header");

            switch (name)
            {
                case "Beaver Mountain":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[1]/div[2]/div[2]/p/span[3]");
                        break;
                    }
                case "Cherry Peak":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[1]/div[3]/div[2]/p/span[3]");
                        break;
                    }
                case "Powder Mountain":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[2]/div[3]/div[2]/p/span[3]");
                        break;
                    }
                case "Nordic Valley":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[2]/div[2]/div[2]/p/span[3]");
                        break;
                    }
                case "Snowbasin":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[2]/div[4]/div[2]/p/span[3]");
                        break;
                    }
                case "Park City":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[4]/div[3]/div[2]/p/span[3]");
                        break;
                    }
                case "Deer Valley":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[4]/div[2]/div[2]/p/span[3]");
                        break;
                    }
                case "Brighton":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[3]/div[3]/div[2]/p/span[3]");
                        break;
                    }
                case "Solitude":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[3]/div[5]/div[2]/p/span[3]");
                        break;
                    }
                case "Alta":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[3]/div[2]/div[2]/p/span[3]");
                        break;
                    }
                case "Snowbird":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[3]/div[4]/div[2]/p/span[3]");
                        break;
                    }
                case "Sundance":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[5]/div[2]/div[2]/p/span[3]");
                        break;
                    }
                case "Eagle Point":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[6]/div[3]/div[2]/p/span[3]");
                        break;
                    }
                case "Brian Head":
                    {
                        resortTime = By.XPath("/html/body/div[2]/div[3]/div[1]/div/div[4]/div[2]/div[6]/div[2]/div[2]/p/span[3]");
                        
                        break;
                    }
            }


            return resortTime;
        }

        public static List<IWebElement> dropdownSearch(IWebDriver driver, string what, string resort, string subcategory)
       
        {
            
            SelectElement dropdown1 = new SelectElement(driver.FindElement(By.Name("filter-category-select")));
           dropdown1.SelectByText(what);
           
            SelectElement dropdown2 = new SelectElement(driver.FindElement(By.Name("filter-resort-select")));
            dropdown2.SelectByText(resort);
           
            SelectElement dropdown3 = new SelectElement(driver.FindElement(By.Name("filter-sub-category-select")));
            dropdown3.SelectByText(subcategory);
           
            driver.FindElement(By.Name("filter-form-submit")).Click();

           // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4000));

            List<IWebElement> searchResult = new List<IWebElement>(driver.FindElements(By.ClassName("ListingResults-item")));
            
            return searchResult;
        }


    }

}


