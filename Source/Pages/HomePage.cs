using OpenQA.Selenium;
using PageObjectModel.Drivers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Test.Pages
{
    public class HomePage : DriverSetup
    {
        
        [FindsBy(How =How.Id,Using = "twotabsearchtextbox")]
        public IWebElement searchBox;
        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        public IWebElement searchBtn;
        [FindsBy(How = How.Id, Using = "nav-link-accountList-nav-line-1")]
        public IWebElement signinLink;

        public HomePage()
        {            
            PageFactory.InitElements(driver, this);
        }

        public void searchText(string text)
        {
            searchBox.SendKeys(text);
            searchBtn.Click();
        }






    }

    
}
