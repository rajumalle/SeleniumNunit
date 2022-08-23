using System;
using System.Security.Policy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumNunit
{
    public class DriverManager
    {
        private DriverManager()
        {
        }
        public static IWebDriver? driver = null;

        public static void init_Browser()
        {
            driver = new ChromeDriver(@"/Users/rajumalle/Documents/GitHub/rajumalleGitHub/TestProjectNUnit/TestProjectNUnit/Utilities");
            driver.Manage().Window.Maximize();
        }
        public string getTitle()
        {
            return driver.Title;
        }

        public void navigate(string url)
        {
            driver.Url = url;
        }

        public static void Close()
        {
            driver.Close();
        }
        public static IWebDriver getDriver()
        {
            if (driver is null)
            {
                init_Browser();
            }
            return driver;      
        }
        
    }
}

