using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson.Serialization.Conventions;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using PageObjectModel.ReportingLibrary;
using PageObjectModel.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Drivers
{
    public enum Browser
    {
        
        Chrome,
        Firefox,
        Edge
    }
    public class DriverSetup : ReportListener
    {
        [ThreadStatic]
        public static IWebDriver driver;

        
        [SetUp]
        public void SetUp() 
        {
            
            Settings1 set = new Settings1();
            string AppUrl = set.practiceURL;
            string browserName = set.BROWSER;

           // Browser.Chrome.ToString();
            
            if (browserName == "Chrome")
                driver = new ChromeDriver();
            else if (browserName== "Firefox")
                driver = new FirefoxDriver();
           else if (browserName.Equals(Browser.Edge.ToString()))
                 driver = new EdgeDriver();

            driver.Navigate().GoToUrl(AppUrl);
        }
        [TearDown]
        public void AfterTest()
        {
            
           driver.Quit();
        }
        
        }

        
    }

 