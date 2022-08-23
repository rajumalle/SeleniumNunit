using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNunit;

namespace TestProjectNUnit;

public class Test1
{

    [Test]
    public void test1()
    {
        IWebDriver? driver = DriverManager.getDriver();
        JupitorPage jupitorPage = new JupitorPage(driver);
        DriverManager.navigate("https://jupiter.cloud.planittesting.com/#/");
        jupitorPage.clickOnShopping();
        DriverManager.Close();

       // IWebDriver webDriver = new ChromeDriver(@"/Users/rajumalle/Downloads/");
        //webDriver.Manage().Window.Maximize();
        //webDriver.Url = "https://jupiter.cloud.planittesting.com/#/";
        //webDriver.Close();
    }
}

