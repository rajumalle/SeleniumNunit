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
    public JupitorPage(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.CssSelector, Using = ".btn-success")]
    private IWebElement ShoppingLink;

    public void clickOnShopping()
    {
        ShoppingLink.Click();
        Console.WriteLine("Clicked on Link");

    }

}



