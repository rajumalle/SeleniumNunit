using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNunit;

namespace TestProjectNUnit;

public class Test3
{

    [Test]
    public void test3()
    {
        IWebDriver? driver = DriverManager.getDriver();
       
        //Launch the Online Store Website
        DriverManager.navigate("https://www.store.demoqa.com");

        // Find the element that's ID attribute is 'account'(My Account) 
        driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();

        // Find the element that's ID attribute is 'log' (Username)
        // Enter Username on the element found by above desc.
        driver.FindElement(By.Id("log")).SendKeys("testuser_1");

        // Find the element that's ID attribute is 'pwd' (Password)
        // Enter Password on the element found by the above desc.
        driver.FindElement(By.Id("pwd")).SendKeys("Test@123");

        // Now submit the form.
        driver.FindElement(By.Id("login")).Click();

        // Find the element that's ID attribute is 'account_logout' (Log Out)
        driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Click();

        // Close the driver
        driver.Quit();
    }
}

