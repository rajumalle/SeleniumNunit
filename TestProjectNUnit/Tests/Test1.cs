using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNunit;

namespace TestProjectNUnit;

public class Test2
{

    [Test]
    public void test2()
    {
        IWebDriver driver = new ChromeDriver(@"/Users/rajumalle/Documents/GitHub/rajumalleGitHub/TestProjectNUnit/TestProjectNUnit/Utilities");
        driver.Url = "https://jupiter.cloud.planittesting.com/#/";
        JupitorPage jupitorPage = new JupitorPage(driver);
        jupitorPage.clickOnShopping();
        driver.Close();

       // IWebDriver webDriver = new ChromeDriver(@"/Users/rajumalle/Downloads/");
        //webDriver.Manage().Window.Maximize();
        //webDriver.Url = "https://jupiter.cloud.planittesting.com/#/";
        //webDriver.Close();
    }
}

