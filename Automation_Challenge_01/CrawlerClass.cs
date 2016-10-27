using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace Automation_Challenge
{
   public class CrawlerClass
    {
       
       private static List<string> linkVisited = new List<string>().Distinct().ToList();
       private static List<string> newLink = new List<string>().Distinct().ToList();
       private static Queue<string> myQ = new Queue<string>();
       
       private static FileStream fs1 = new FileStream("F:\\Screenshot\\Newlink.txt", FileMode.OpenOrCreate, FileAccess.Write);
       private static StreamWriter writer = new StreamWriter(fs1);

       private static FileStream fs2 = new FileStream("F:\\Screenshot\\Linkvisited.txt", FileMode.OpenOrCreate, FileAccess.Write);
       private static StreamWriter writer2 = new StreamWriter(fs2);
       

       public static void getNewlink(IWebDriver driver)
        {
           List<IWebElement> slink = new List<IWebElement>(driver.FindElements(By.TagName("a")));

           foreach (IWebElement link in slink)
           {
               //newLink.Add(link.GetAttribute("href"));

              writer.Write(link.GetAttribute("href") + Environment.NewLine);

               if (!myQ.Contains(link.GetAttribute("href")) && !linkVisited.Contains(link.GetAttribute("href")))
               {
                   myQ.Enqueue(link.GetAttribute("href"));
                   writer.Write(link.GetAttribute("href") + Environment.NewLine);
               }
           }
            // writer.Close();
        }



        public static List<string> Crawler(IWebDriver driver)
        {
           List<IWebElement> anchorLink = new List<IWebElement>(driver.FindElements(By.TagName("a")));

            foreach (IWebElement lik in anchorLink)
            {
                myQ.Enqueue(lik.GetAttribute("href"));
            }

            //getNewlink(driver);
           
           writer2.Write(Environment.NewLine+" Total Links  " +myQ.Count+ Environment.NewLine);
           writer2.Write("Links Visited: " + Environment.NewLine);
           
           //loop over all the anchor element in the page
           for (int i = 0; i < (myQ.Count); i++)
           {    
               string temp = myQ.Dequeue();
               
               //need to add code to check is link going to skiutah site or external link?
               if (!linkVisited.Contains(temp) && temp.Contains("https://www.skiutah.com/"))
               {
                   //try
                   //{
                   //    driver.Navigate().GoToUrl(temp);
                   //}
                   //catch (TimeoutException toe)
                   //{
                   //    driver.Navigate().Refresh();
                   //}

                   // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(200));
                   //Screenshot sh = driver.TakeScreenshot();
                    //sh.SaveAsFile(@"F:/Screenshot/Page"+i+".jpeg", ImageFormat.Jpeg);
                   //Thread.Sleep(4000);

                   linkVisited.Add(temp);
                   writer2.Write(i+" visited link= " + temp + Environment.NewLine);

                 //  getNewlink(driver);
                }
           }
           return linkVisited;
       }
    }
}
