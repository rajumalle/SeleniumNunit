using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectNUnit;

public class JupitorPage
{
    IWebDriver webDriver;
    public JupitorPage(IWebDriver driver)
    {
        webDriver = driver;
        PageFactory.InitElements(driver, this);
    }

    public string URL = "https://jupiter.cloud.planittesting.com/#/";

    [FindsBy(How = How.CssSelector, Using = ".btn-success")]
    public IWebElement ShoppingLink;

    [FindsBy(How = How.Name, Using = "firstname")]
    public IWebElement FirstName;

    [FindsBy(How = How.Id, Using = "lastname")]
    public IWebElement LastName;


    public  void navigateToJupitor()
    {
        webDriver.Url = URL;
    }

    public void clickOnShopping()
    {
        ShoppingLink.Click();
        Console.WriteLine("Clicked on Link");

    }

}



