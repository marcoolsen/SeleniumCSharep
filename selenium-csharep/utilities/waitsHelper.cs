using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace selenium_csharep.utilities
{
	public class waitsHelper
	{
        public WebElement waitForClickablility(By locator, int timeout, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            return (WebElement)wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public WebElement waitForVisility(By locator, int timeout, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            return (WebElement)wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public WebElement waitForElementExist(By locator, int timeout, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            return (WebElement)wait.Until(ExpectedConditions.ElementExists(locator));
        }

        public Boolean waitInvisibilityElement(By locator, int timeout, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            return (Boolean)wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
        }
    }
}

