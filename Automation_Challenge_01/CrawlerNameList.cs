using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Text;
using System.Net.Http;



namespace Automation_Challenge
{
    public class GoodController
    {
        // OK
        private static readonly HttpClient HttpClient;

        static GoodController()
        {
            HttpClient = new HttpClient();
        }
    }


    [TestClass]
    public class CrawlerNameList
    {
        private string siteName = "https://www.skiutah.com";
        private string homeTitle = "Ski Utah - Ski Utah";
        private int invalidImageCount;

        private static FileStream fs2 = new FileStream("F:\\Screenshot\\Dictionary\\Dictionary.txt",
            FileMode.OpenOrCreate, FileAccess.Write);

        private static StreamWriter writer2 = new StreamWriter(fs2);

        private static FileStream fs3 = new FileStream("F:\\Screenshot\\Dictionary\\Bodytext.txt", FileMode.OpenOrCreate,
            FileAccess.Write);

        private static StreamWriter textWriter = new StreamWriter(fs3);

        private static FileStream fs4 = new FileStream("F:\\Screenshot\\Dictionary\\Imagetext.txt", FileMode.OpenOrCreate,
          FileAccess.Write);

        private static StreamWriter imwriter = new StreamWriter(fs4);



        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void Challenge7_crawlerDictionary()
        {
            IWebDriver driver = BrowserFactory.StartBrowser(siteName, homeTitle);
            IWebElement body = driver.FindElement(By.TagName("body"));
            string validText = body.Text.ToLower().Trim();
            int totalWords = 0;
            int checktotal = 0;
            Dictionary<string, int> wordList = new Dictionary<string, int>();
            while (validText.Contains(",") || validText.Contains("."))
            {
                validText = validText.Replace(",", " ");
                validText = validText.Replace(".", " ");
            }

            while (validText.Contains(Environment.NewLine))
                validText = validText.Replace(Environment.NewLine, " ");

            while (validText.Contains("  "))
                validText = validText.Replace("  ", " ");

            foreach (var y in validText.Split(' '))
            {
                totalWords++;
                try
                {
                    wordList.Add(y, 1);
                }
                catch (Exception)
                {
                    wordList[y] = wordList[y] + 1;
                }
            }
            foreach (KeyValuePair<string, int> kvp in wordList)
            {
                writer2.Write("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                writer2.Write(Environment.NewLine);
                checktotal = checktotal + kvp.Value;
            }

            writer2.Write(Environment.NewLine + "Total words= " + checktotal + Environment.NewLine +
                          "Total keys in dictionary= " + wordList.Count + Environment.NewLine);
            writer2.Write(
                "=============================================================================================");

            textWriter.Write(Environment.NewLine + "Total words in body= " + totalWords + Environment.NewLine);
            textWriter.Write(Environment.NewLine + validText + Environment.NewLine);

            writer2.Close();
            textWriter.Close();
            driver.Quit();
        }

        public virtual void GetBodyText(IWebDriver driver)
        {
            IWebElement body = driver.FindElement(By.TagName("body"));
            string validText = body.Text.ToLower().Trim();
            int totalWords = 0;
            int checktotal = 0;
            Dictionary<string, int> wordList = new Dictionary<string, int>();

            while (validText.Contains(",") || validText.Contains("."))
            {
                validText = validText.Replace(",", " ");
                validText = validText.Replace(".", " ");
            }

            while (validText.Contains(Environment.NewLine))
                validText = validText.Replace(Environment.NewLine, " ");

            while (validText.Contains("  "))
                validText = validText.Replace("  ", " ");

            foreach (var y in validText.Split(' '))
            {
                totalWords++;
                try
                {
                    wordList.Add(y, 1);
                }
                catch (Exception)
                {
                    wordList[y] = wordList[y] + 1;
                }
            }
            writer2.Write(Environment.NewLine + "In " + driver.Url + Environment.NewLine);
            foreach (KeyValuePair<string, int> kvp in wordList)
            {
                writer2.Write("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                writer2.Write(Environment.NewLine);
                checktotal = checktotal + kvp.Value;
            }

            writer2.Write(Environment.NewLine + "Total words= " + checktotal + Environment.NewLine +
                          "Total keys in dictionary= " + wordList.Count + Environment.NewLine);
            writer2.Write(
                "=============================================================================================");

            textWriter.Write(Environment.NewLine + "In " + driver.Url);
            textWriter.Write(Environment.NewLine + "Total words in body= " + totalWords + Environment.NewLine);
            textWriter.Write(Environment.NewLine + validText + Environment.NewLine);
        }

        public virtual void GetBrokenImage(IWebDriver driver)
        {
            try
            {
                invalidImageCount = 0;
                IList<IWebElement> imagesList = driver.FindElements(By.TagName("img"));
                imwriter.Write("In "+driver.Url+Environment.NewLine);
                imwriter.Write("Total no. of images are " + imagesList.Count+Environment.NewLine);
                foreach (IWebElement imgElement in imagesList)
                {
                    if (imgElement != null)
                    {
                        verifyimageActive(imgElement);
                    }
                }
                imwriter.Write("Total no. of invalid images are " + invalidImageCount+Environment.NewLine);
            }
            catch (Exception e)
            {
                TestContext.WriteLine(e.ToString());
                TestContext.WriteLine(e.StackTrace);
                TestContext.WriteLine(e.Message);
            }

        }

        public virtual async void verifyimageActive(IWebElement imgElement)
        {
           
           
                // Create a New HttpClient object.

                HttpClient client = new HttpClient();
                string sss = imgElement.GetAttribute("src");

                HttpResponseMessage response = await client.GetAsync(sss);

                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode == false)
                    invalidImageCount++;

            
        }
   

[TestMethod]
    public virtual void CRAWLER()
    {
        IWebDriver driver = BrowserFactory.StartBrowser(siteName, homeTitle);
		
		IList<IWebElement> all_links_webpage = driver.FindElements(By.TagName("a"));
		ISet<string> all_valid_links_webpage = new HashSet<string>();
       // Dictionary<string, int> wordList = new Dictionary<string, int>();
		
        int k = all_links_webpage.Count;
        
		TestContext.WriteLine("Page wise link browse: ");

		for (int i = 0; i < k; i++)
		{
			//do not consider empty link or # link or non http prefix link
			if (!all_links_webpage[i].GetAttribute("href").Contains("#") && all_links_webpage[i].GetAttribute("href").Contains("https://www.skiutah.com/"))
			{
				string link = all_links_webpage[i].GetAttribute("href");
				try
				{
					all_valid_links_webpage.Add(link);
				}
				catch (Exception)
				{
					TestContext.WriteLine("Duplicate link url Detected");
				}
			}
		}
		
        ISet<string> newSet = all_valid_links_webpage;
		bool flag = true;
        
		while (flag)
		{
			ISet<string> all_valid_links_webpage1 = new HashSet<string>();

			foreach (string newLink in newSet)
			{
				int i = 0;
				TestContext.WriteLine(newLink);
			    driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromMinutes(4));
			    try
                {
					//writer2.Write(driver.FindElement(By.TagName("body")).Text);
                    //GetBodyText(driver);
                    
                    GetBrokenImage(driver);
				    
				}
				catch (IOException e)
				{
					TestContext.WriteLine(e.ToString());
					TestContext.WriteLine(e.StackTrace);
				}

                try
			    {
			        driver.Navigate().GoToUrl(newLink);
			    }
			    catch (WebException)
			    {
			        driver.Navigate().Refresh();
			    }
			    //IList<IWebElement> imagesList = driver.FindElements(By.TagName("img"));
				
                IList<IWebElement> all_links_webpage1 = driver.FindElements(By.TagName("a"));

				if ( !all_links_webpage1[i].GetAttribute("href").Contains("#") && all_links_webpage1[i].GetAttribute("href").Contains("https://www.skiutah.com/"))
				{
					string link = all_links_webpage1[i].GetAttribute("href");
					try
					{
						all_valid_links_webpage1.Add(link);
					}
					catch (Exception)
					{
						TestContext.WriteLine("Duplicate link value Detected");
					}
				}
				i++;
			}
			newSet = null;
			foreach (string value in all_valid_links_webpage1)
			{
				if (all_valid_links_webpage1.Contains(value))
				{
					flag = false;
				}
				else
				{
					try
					{
						all_valid_links_webpage.Add(value);
					}
					catch (Exception)
					{
						TestContext.WriteLine("Duplicate link value Detected");
					}

					newSet.Add(value);
					flag = true;
				}
			}
        }
        writer2.Close();
        textWriter.Close();
        driver.Quit();
}


        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContextInstance { get; set; }
    }
}
