using OpenQA.Selenium;

using PageObjectModel.Drivers;
using PageObjectModel.Test.Pages;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Source.Pages
{
    class LoginPage : DriverSetup
    {
        
        [FindsBy(How = How.XPath, Using = "//div[@class='nav-line-1-container']")]
        public IWebElement signInLink;

        
        [FindsBy(How = How.Id, Using = "ap_email")]
        public IWebElement userID;

        [FindsBy(How = How.Id, Using = "continue")]
        public IWebElement contunueBtn;

        [FindsBy(How=How.Id,Using = "ap_password")]
        public IWebElement password;
        
        [FindsBy(How = How.XPath, Using = "//span[@class='a-list-item']")]
        public IWebElement wrongPasswordMsg;
       
        [FindsBy(How = How.Id, Using = "createAccountSubmit")]
        public IWebElement createAccountBtn;

        public string loginWithEmail(string email,string passwordTxt)
        {
            HomePage homepage = new HomePage();
            homepage.signinLink.Click();           
            userID.SendKeys(email);
            contunueBtn.Click();
            password.SendKeys(passwordTxt);
            password.SendKeys(Keys.Enter);
            return wrongPasswordMsg.Text;            
        }

        public void createAccount(String Name,string email,string password, string v)
        {
            HomePage homepage = new HomePage();
            homepage.signinLink.Click();
            createAccountBtn.Click();
            driver.FindElement(By.Id("ap_customer_name")).SendKeys(Name);
            driver.FindElement(By.Id("ap_email")).SendKeys(email);
            driver.FindElement(By.Id("ap_password")).SendKeys(password);
            driver.FindElement(By.Id("ap_password_check")).SendKeys(password);

            contunueBtn.Click() ;
        }
        public LoginPage() 
        {         
            PageFactory.InitElements(driver, this);
        }
    }
}
