using java.util;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using PageObjectModel.Drivers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ArrayList = System.Collections.ArrayList;
using Hashtable = System.Collections.Hashtable;

namespace PageObjectModel.Test
{
    
    class practice_Test : DriverSetup
    {
        [Test, Category("practice"),Order(1)]
        public void alert()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div[1]/button")).Click();
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(20000);            
        }


        [Test, Category("practice"),Order(2)]
        public void scroll()
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350);");
            Thread.Sleep(6000);

        }
        [Test, Category("practice")]
        public void dragAndDrop()
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,650);");            
            Thread.Sleep(7000);

            IWebElement source = driver.FindElement(By.Id("drag1"));
            IWebElement dest = driver.FindElement(By.Id("div1"));

           
            Actions action = new Actions(driver);
            action.ClickAndHold(source).DragAndDrop(source, dest).Build().Perform();
            
            Thread.Sleep(10000);
        }

        [Test, Category("practice")]
        public void move_Scroll_Bar()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,750);");
            IWebElement scrollBar = driver.FindElement(By.Id("a"));            
            IWebElement scrollTill = driver.FindElement(By.XPath("//output[@name='x']"));
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(scrollBar, 40, 0).Build().Perform();
            string val = scrollTill.Text;
            Console.WriteLine("the value is : " + val);
  
            Thread.Sleep(10000);

            //assertions of the text 
            string actualText = driver.FindElement(By.XPath("//label[@for='ranges']")).Text;
            string expectedText = "Scroll to see a range value:";

            Assert.AreEqual(actualText, expectedText);

        }

        [Test, Category("practice")]
        public void upload_File()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,750);");

            driver.FindElement(By.Name("myfile")).SendKeys(@"C:\Users\Sukannya Ghosh\source\repos\PageObjectModel");
        }

        [Test, Category("practice")]
        public void Get_text_from_Footer()
        {
            string text = driver.FindElement(By.XPath("//div[@class='main']/p[2]")).Text;
            Console.WriteLine(text);

            
        }

        [Test, Category("practice")]
        public void guessText()
        {
            IWebElement ele = driver.FindElement(By.XPath("//input[@name='Options']"));
            ele.SendKeys("cho");
            ele.SendKeys(Keys.Enter);
            Thread.Sleep(10000);
            //Console.WriteLine(text);
        }
        [Test]
        public void non_generic_Collections()
        {
            ArrayList al = new ArrayList();
            al.Add("Python");
            al.Add("csharp");
            al.Insert(1, "java 8");

            for(int i =0 ; i < al.Count; i++) 
            {
                Console.WriteLine(al[i]);
            }

            //hashtable
            Hashtable hb = new Hashtable();
            hb.Add("name", "TOM");
            hb.Add("address","new york");

            foreach(DictionaryEntry de in hb)
            {
                Console.WriteLine(de.Key +" is "+ de.Value);
            }


        }

        [Test]
        public void generic_Collection()
        {
            //Dictionaries
            Dictionary<int,String> dict = new Dictionary<int, string>();
            dict.Add(23, "Mindfire");
            dict.Add(66, "Solutions");

            dict.Remove(23);

            foreach(var val in dict)
            {
                Console.WriteLine("key={0} and value={1}", val.Key,val.Value);
            }
            
        }

    }
}
