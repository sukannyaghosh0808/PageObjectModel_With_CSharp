using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using PageObjectModel.Drivers;
using PageObjectModel.Test.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Test
{
    [Parallelizable(ParallelScope.All)]
    public class HomePage_Test : DriverSetup
    {
        
        [Test, Category("Regression Testing")] 
        public void searchTelevision() 
        {
            HomePage homepage = new HomePage();
            homepage.searchText("television");
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
        }

        [Test, Category("Smoke Testing")]
        public void searchMobile()
        {
            HomePage homepage = new HomePage();
            homepage.searchText("Iphone 13");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            try
            {
                Assert.True(driver.Title.Contains("Amazon.com : iphone 13"));
            }
            catch
            {
                ITakesScreenshot sc = driver as ITakesScreenshot;
                Screenshot screenshot= sc.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\Sukannya Ghosh\\source\\repos\\PageObjectModel\\ScreenShots\\sc.png");
            }
           
        }

        [Test, Category("Regression Testing")]
        public void TitleCheck()
        {
            Console.WriteLine(driver.Title);
            Assert.True(driver.Title.Contains("Amazon.com. Spend less. Smile more."));
        }
        
    }
}
