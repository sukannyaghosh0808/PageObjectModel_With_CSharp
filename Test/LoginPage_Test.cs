using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectModel.Source.Pages;
using PageObjectModel.Drivers;
using PageObjectModel.Source.Utilities;
using System.Security.Cryptography.X509Certificates;
using AventStack.ExtentReports;
using PageObjectModel.ReportingLibrary;

namespace PageObjectModel.Test
{
    [Parallelizable(ParallelScope.All)]
    class LoginPage_Test : DriverSetup
    {
        
        Util util;
        

        [Test,Category("Regression Testing")]
        public void invalidLogin()
        {
            LoginPage loginpage = new LoginPage();
            Settings1 set = new Settings1();
            string email = set.email;
            string pw = set.password;
            string message = loginpage.loginWithEmail(email,pw);

            
            if (message.Equals("Your password is incorrect"))
            {
                Console.WriteLine("Test Passed : InvalidLogin");
            }
            else
            {
                util = new Util();
                util.TakesScreenshot("invalidLogin");
                
            }
        }

        [Test, Category("Regression Testing")]
        public void create_account_with_invalid_datal() 
        {            
            LoginPage loginpage1 = new LoginPage();
            loginpage1.createAccount("Sukannya","as4","123","123");
        }

        [Test,Category("Regression Testing")]
        public void create_acc()
        {
            Util.PopulateInCollection(@"C:\Users\Sukannya Ghosh\source\repos\PageObjectModel\Source\TestData\testdata.xlsx");
        }
    }
}
